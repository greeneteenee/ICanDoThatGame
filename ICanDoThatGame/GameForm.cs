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

        //Create your private font collection object.
        PrivateFontCollection pfc = new PrivateFontCollection();

        Game thisGame = new Game();
        Player player1 = new Player("Thing 1");
        Player player2 = new Player("Thing 2");
        Player currPlayer = null;
        //player1 turn
        bool turn = false;

        int numTurns = 0;
        

        public void btnAction_Click(object sender, EventArgs e)
        {
    
            string randomAction = ActionItemDB.GetRandomAction();
            lblAction.Text = randomAction;
            //MessageBox.Show(randomAction);
            panelAction.Visible = true;
            btnAction.Enabled = false;
            if(CheckEnabled() == true)
            {
                turn = thisGame.ChangeTurn(turn, currPlayer);
                PlayerTurn(turn);
            }
        
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            string randomWhere = WhereItemDB.GetRandomWhere();
            lblWhere.Text = randomWhere;
            //MessageBox.Show(randomWhere);
            panelWhere.Visible = true;
            btnWhere.Enabled = false;
            if (CheckEnabled() == true)
            {
                turn = thisGame.ChangeTurn(turn, currPlayer);
                PlayerTurn(turn);
            }
        }

        private void btnWith_Click(object sender, EventArgs e)
        {
            string randomWith = WithItemDB.GetRandomWith();
            lblWith.Text = randomWith;
            //MessageBox.Show(randomWith);
            panelWith.Visible = true;
            btnWith.Enabled = false;
            if (CheckEnabled() == true)
            {
                turn = thisGame.ChangeTurn(turn, currPlayer);          
                PlayerTurn(turn);
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

        /// <summary>
        /// This method increases player 1 score by one point when label is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void p1ScoreLabel_Click(object sender, EventArgs e)
        {
        //    p1ScoreLabel.Text = (Int32.Parse(p1ScoreLabel.Text) + 1).ToString();
            
        }

        /// <summary>
        /// This method increases player 2 score by one point when label is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void p2ScoreLabel_Click(object sender, EventArgs e)
        {
        //    p2ScoreLabel.Text = (Int32.Parse(p2ScoreLabel.Text)+1).ToString();
        }

        /// <summary>
        /// This method asks player 1 if they want to descrease the score by one point (i.e. undo point increase) if label is right-clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void p1ScoreLabel_MouseUp(object sender, MouseEventArgs e)
        {
        //    if (e.Button == MouseButtons.Right)
        //    {
        //        DialogResult dialogResult = MessageBox.Show("Do you want to undo point?", "Undo?", MessageBoxButtons.YesNo);
        //        if (dialogResult == DialogResult.Yes)
        //        {
        //            p1ScoreLabel.Text = (Int32.Parse(p1ScoreLabel.Text) - 1).ToString();
        //        }
        //        else if (dialogResult == DialogResult.No)
        //        {
        //            //do nothing
        //        }
        //    }
        }

   
        /// <summary>
        /// This method asks player 2 if they want to descrease the score by one point (i.e. undo point increase) if label is right-clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void p2ScoreLabel_MouseUp_1(object sender, MouseEventArgs e)
        {
        //    if (e.Button == MouseButtons.Right)
        //    {
        //        DialogResult dialogResult = MessageBox.Show("Do you want to undo point?", "Undo?", MessageBoxButtons.YesNo);
        //        if (dialogResult == DialogResult.Yes)
        //        {
        //            p2ScoreLabel.Text = (Int32.Parse(p2ScoreLabel.Text) - 1).ToString();
        //        }
        //        else if (dialogResult == DialogResult.No)
        //        {
        //            //do nothing
        //        }
        //    }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (!PlayerNameValid(p1NameTextBox.Text, player1.MaxPlayerNameLength))
            {
                MessageBox.Show("Please enter player name");
                btnStartGame.Enabled = false;
            }
            else if (!PlayerNameValid(p2NameTextBox.Text, player2.MaxPlayerNameLength))
            {
                MessageBox.Show("Please enter player name");
                btnStartGame.Enabled = false;
            }
            else
            {
                btnStartGame.Visible = false;

                //players can't change their name after game starts
                p1NameTextBox.Enabled = false;
                p2NameTextBox.Enabled = false;

                //set players names to what is in player TextBox's, defaults to "Thing 1" and "Thing 2"
                player1.PlayerName = p1NameTextBox.Text;
                player2.PlayerName = p2NameTextBox.Text;

                //show player scores, starting with zero
                p1ScoreLabel.Text = player1.PlayerScore.ToString();
                p2ScoreLabel.Text = player2.PlayerScore.ToString();


                PlayerTurn(turn);
            }
        }

        public void PlayerTurn(bool turn)
        {
            numTurns += 1;
            

            p1ScoreLabel.Text = player1.PlayerScore.ToString();
            p2ScoreLabel.Text = player2.PlayerScore.ToString();
            

            if (thisGame.OutOfTurns(numTurns) == true)
            {
                string winnerName = thisGame.CheckWinner(player1, player2);
                MessageBox.Show($"Game over. {winnerName} wins!");
                this.Close();
            }

            
            btnAction.Enabled = true;
            btnWhere.Enabled = true;
            btnWith.Enabled = true;
            panelAction.Visible = false;
            panelWhere.Visible = false;
            panelWith.Visible = false;

            if (turn == false)
            {
                currPlayer = player1;
            }
            else
            {
                currPlayer = player2;
            }

            //if it is player1's turn, highlight player
            if (turn == false)
            {
                p1Panel.Visible = true;               
                p2Panel.Visible = false;
                p1NameTextBox.BackColor = Color.Black;
                p2NameTextBox.BackColor = Color.Empty;
                p1ScoreLabel.BackColor = Color.Black;
                p1ScoreLabel.ForeColor = Color.White;
                p2ScoreLabel.BackColor = Color.Empty;
                p2ScoreLabel.ForeColor = Color.Gray;
            }
            else
            {
                p1Panel.Visible = false;
                p2Panel.Visible = true;
                p2NameTextBox.BackColor = Color.Black;
                p1NameTextBox.BackColor = Color.Empty;
                p2ScoreLabel.BackColor = Color.Black;
                p2ScoreLabel.ForeColor = Color.White;
                p1ScoreLabel.BackColor = Color.Empty;
                p1ScoreLabel.ForeColor = Color.Gray;

            }

            int turnsLeft = thisGame.TurnsLeft(numTurns);
            lblTurnLeftInt.Text = turnsLeft.ToString();
        }

        public bool CheckEnabled()
        {
            if (btnAction.Enabled == false && btnWhere.Enabled == false && btnWith.Enabled == false)
            {
                return true;
            }
            return false;
        }

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

        private void GameForm_Load(object sender, EventArgs e)
        {
            CustomFontARCarter();
            btnAction.Font = new Font(pfc.Families[0], 36);
            btnWhere.Font = new Font(pfc.Families[0], 36);
            btnWith.Font = new Font(pfc.Families[0], 36);
        }

       
        public bool PlayerNameValid(string name, int maxLength)
        {
            name.Trim();
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }
            else if (name.Length > maxLength)
            {
                return false;
            }
            return true;
        }

        private void p1NameTextBox_TextChanged(object sender, EventArgs e)
        {
            btnStartGame.Enabled = true;
                       
        }
              

        private void p2NameTextBox_TextChanged(object sender, EventArgs e)
        {
            btnStartGame.Enabled = true;
          
        }
    }
}
