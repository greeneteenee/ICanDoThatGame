using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICanDoThatGame
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        //Create your private font collection object
        PrivateFontCollection pfc = new PrivateFontCollection();

        Game thisGame = new Game();
        Player player1 = new Player("Thing 1");
        Player player2 = new Player("Thing 2");
        Player currPlayer = null;
        
        //player1 turn
        bool turn = false;

        int numTurns = 0;
        
        /// <summary>
        /// Action game card is flipped when button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnAction_Click(object sender, EventArgs e)
        {
    
            string randomAction = ActionItemDB.GetRandomAction();
            lblAction.Text = randomAction;
            panelAction.Visible = true;
            btnAction.Enabled = false;
            if(CheckEnabled() == true)
            {
                ShowThumbsButtons();              
            }

        }

        /// <summary>
        /// Place game card is flipped when button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWhere_Click(object sender, EventArgs e)
        {
            string randomWhere = WhereItemDB.GetRandomWhere();
            lblWhere.Text = randomWhere;      
            panelWhere.Visible = true;
            btnWhere.Enabled = false;
            if (CheckEnabled() == true)
            {
                ShowThumbsButtons();               
            }
        }

        /// <summary>
        /// Challenge game card is flipped when button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWith_Click(object sender, EventArgs e)
        {
            string randomWith = WithItemDB.GetRandomWith();
            lblWith.Text = randomWith;            
            panelWith.Visible = true;
            btnWith.Enabled = false;
            if (CheckEnabled() == true)
            {
                ShowThumbsButtons();               
            }
        }

        /// <summary>
        /// Displays thumbs up/down buttons for each players turn
        /// </summary>
        private void ShowThumbsButtons()
        {
            if (turn == false)
            {
                p1SuccessText.Visible = true;
                p1ThumbsDown.Visible = true;
                p1ThumbsUp.Visible = true;
            }
            else
            {
                p2SuccessText.Visible = true;
                p2ThumbsDown.Visible = true;
                p2ThumbsUp.Visible = true;
            }
        }

        /// <summary>
        /// This method opens the CustomizeGameForm when the "Customize Form" button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenCustomizeForm_Click(object sender, EventArgs e)
        {
            CustomizeGameForm customizeForm = new CustomizeGameForm();
            customizeForm.Show();
        }          

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            //if player names are not valid disable start button
            if (!player1.PlayerNameValid(p1NameTextBox.Text, player1.MaxPlayerNameLength))
            {
                MessageBox.Show("Please enter player name");
                btnStartGame.Enabled = false;
            }
            else if (!player2.PlayerNameValid(p2NameTextBox.Text, player2.MaxPlayerNameLength))
            {
                MessageBox.Show("Please enter player name");
                btnStartGame.Enabled = false;
            }
            else
            {
                //hide start button and show exit button when game starts
                btnStartGame.Visible = false;
                btnExitGame.Visible = true;

                //players can't change their name after game starts
                p1NameTextBox.Enabled = false;
                p2NameTextBox.Enabled = false;

                //set players names to what is in player TextBox's, defaults to "Thing 1" and "Thing 2"
                player1.PlayerName = p1NameTextBox.Text;
                player2.PlayerName = p2NameTextBox.Text;
                                              
                PlayerTurn(turn);
            }
        }

        //re-enables start buttons if player attempts to correct name (i.e. changes text in player name TextBoxes)
        private void p1NameTextBox_TextChanged(object sender, EventArgs e)
        {
            btnStartGame.Enabled = true;
        }
        private void p2NameTextBox_TextChanged(object sender, EventArgs e)
        {
            btnStartGame.Enabled = true;
        }

        /// <summary>
        /// When thumbs up button is clicked, player 1 score is increased, player turn is ended and thumbs up/down buttons are hidden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void p1ThumbsUp_Click(object sender, EventArgs e)
        {
            player1.UpdatePlayerScore(player1);
            p1ScoreLabel.Text = player1.PlayerScore.ToString();
            turn = thisGame.ChangeTurn(turn);
            PlayerTurn(turn);
            p1SuccessText.Visible = false;
            p1ThumbsDown.Visible = false;
            p1ThumbsUp.Visible = false;

        }

        /// <summary>
        /// When thumbs down button is clicked, player 1 turn is ended and thumbs up/down buttons are hidden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void p1ThumbsDown_Click(object sender, EventArgs e)
        {
            turn = thisGame.ChangeTurn(turn);
            PlayerTurn(turn);
            p1SuccessText.Visible = false;
            p1ThumbsDown.Visible = false;
            p1ThumbsUp.Visible = false;
        }

        /// <summary>
        /// When thumbs up button is clicked, player 2 score is increased, player turn is ended and thumbs up/down buttons are hidden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void p2ThumbsUp_Click(object sender, EventArgs e)
        {
            player2.UpdatePlayerScore(player2);
            p2ScoreLabel.Text = player2.PlayerScore.ToString();
            turn = thisGame.ChangeTurn(turn);
            PlayerTurn(turn);
            p2SuccessText.Visible = false;
            p2ThumbsDown.Visible = false;
            p2ThumbsUp.Visible = false;
        }

        /// <summary>
        /// When thumbs down button is clicked, player 2 turn is ended and thumbs up/down buttons are hidden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void p2ThumbsDown_Click(object sender, EventArgs e)
        {
                                
            turn = thisGame.ChangeTurn(turn);
            PlayerTurn(turn);
            p2SuccessText.Visible = false;
            p2ThumbsDown.Visible = false;
            p2ThumbsUp.Visible = false;
        }

        /// <summary>
        /// This method changes player turns
        /// </summary>
        /// <param name="turn"></param>
        public void PlayerTurn(bool turn)
        {
          
            //show player scores, starting with zero
            p1ScoreLabel.Text = player1.PlayerScore.ToString();
            p2ScoreLabel.Text = player2.PlayerScore.ToString();

            //increment what turn it is on each turn
            numTurns += 1;            
            
            //if there's no more turns, show winner and exit game
            if (thisGame.OutOfTurns(numTurns) == true)
            {
                string winnerName = thisGame.CheckWinner(player1, player2);
                DisplayWinnerScreen winnerScreen = new DisplayWinnerScreen();
                winnerScreen.Winner = winnerName;
                winnerScreen.Show();               
                this.Hide();
            }
            
            //reset game cards
            btnAction.Enabled = true;
            btnWhere.Enabled = true;
            btnWith.Enabled = true;
            panelAction.Visible = false;
            panelWhere.Visible = false;
            panelWith.Visible = false;

            //decide who's turn it is
            if (turn == false)
            {
                currPlayer = player1;
            }
            else
            {
                currPlayer = player2;
            }

            //if it is player1's turn, highlight player1 on game form
            if (turn == false)
            {
                p1panel.BackColor = Color.Black;               
                p2panel.BackColor = Color.Transparent;
                
                p1NameTextBox.BackColor = Color.Black;
                p2NameTextBox.BackColor = Color.Empty;
                p1ScoreLabel.BackColor = Color.Black;
                p1ScoreLabel.ForeColor = Color.White;
                p2ScoreLabel.BackColor = Color.Empty;
                p2ScoreLabel.ForeColor = Color.Gray;
            }
            else //if it's player2's turn, highlight player 2 on game form
            {
                p1panel.BackColor = Color.Transparent;
                p2panel.BackColor = Color.Black;
                p2NameTextBox.BackColor = Color.Black;
                p1NameTextBox.BackColor = Color.Empty;
                p2ScoreLabel.BackColor = Color.Black;
                p2ScoreLabel.ForeColor = Color.White;
                p1ScoreLabel.BackColor = Color.Empty;
                p1ScoreLabel.ForeColor = Color.Gray;

            }
            

            // show number of turns left of game form
            int turnsLeft = thisGame.TurnsLeft(numTurns);
            lblTurnLeftInt.Text = turnsLeft.ToString();
            
        }

        /// <summary>
        /// This method checks if all the game card buttons are disabled (i.e. the button was pressed and the card was flipped over)
        /// </summary>
        /// <returns></returns>
        public bool CheckEnabled()
        {
            if (btnAction.Enabled == false && btnWhere.Enabled == false && btnWith.Enabled == false)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// This method initializes a custom font for the game card buttons
        /// </summary>
        public void CustomFontARCarter()
        {
          
            //Select your font from the resources.
            //My font here is "Digireu.ttf"
            int fontLength = Properties.Resources.ARCARTER.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.ARCARTER;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
            pfc.AddMemoryFont(data, fontLength);
        }

        /// <summary>
        /// Font is applied to game card buttons when form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameForm_Load(object sender, EventArgs e)
        {
            CustomFontARCarter();
            btnAction.Font = new Font(pfc.Families[0], 36);
            btnWhere.Font = new Font(pfc.Families[0], 36);
            btnWith.Font = new Font(pfc.Families[0], 36);
        }  
            
        //Exit game
        private void btnExitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void p1Picture_DoubleClick(object sender, EventArgs e)
        {
            ChangePlayerImg(p1Picture);
        }

        private void p2Picture_DoubleClick(object sender, EventArgs e)
        {
            ChangePlayerImg(p2Picture);
        }

        private void ChangePlayerImg(PictureBox pictureBox)
        {
            //enable user to select picture location
            OpenFileDialog getImg = new OpenFileDialog();
            getImg.Multiselect = false;//user can only open one file
            getImg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";//only image files should be selected
            if (getImg.ShowDialog() == DialogResult.OK)
            {
                //get path of file
                string filePath = getImg.FileName;
                pictureBox.ImageLocation = filePath;

            }
        }
      
    }
}
