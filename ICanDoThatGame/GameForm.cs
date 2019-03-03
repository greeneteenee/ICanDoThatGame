using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        Game newGame = new Game();


        private void btnAction_Click(object sender, EventArgs e)
        {
    
            string randomAction = ActionItemDB.GetRandomAction();
            lblAction.Text = randomAction;
            //MessageBox.Show(randomAction);
            panelAction.Visible = true;
            btnAction.Enabled = false;
            if(CheckEnabled() == true)
            {
                throw new NotImplementedException();
            }
        
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            string randomWhere = WhereItemDB.GetRandomWhere();
            lblWhere.Text = randomWhere;
            //MessageBox.Show(randomWhere);
            panelWhere.Visible = true;
            btnWhere.Enabled = false;
        }

        private void btnWith_Click(object sender, EventArgs e)
        {
            string randomWith = WithItemDB.GetRandomWith();
            lblWith.Text = randomWith;
            //MessageBox.Show(randomWith);
            panelWith.Visible = true;
            btnWith.Enabled = false;
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
            p1ScoreLabel.Text = (Int32.Parse(p1ScoreLabel.Text) + 1).ToString();
            
        }

        /// <summary>
        /// This method increases player 2 score by one point when label is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void p2ScoreLabel_Click(object sender, EventArgs e)
        {
            p2ScoreLabel.Text = (Int32.Parse(p2ScoreLabel.Text)+1).ToString();
        }

        /// <summary>
        /// This method asks player 1 if they want to descrease the score by one point (i.e. undo point increase) if label is right-clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void p1ScoreLabel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to undo point?", "Undo?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    p1ScoreLabel.Text = (Int32.Parse(p1ScoreLabel.Text) - 1).ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                }
            }
        }

   
        /// <summary>
        /// This method asks player 2 if they want to descrease the score by one point (i.e. undo point increase) if label is right-clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void p2ScoreLabel_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to undo point?", "Undo?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    p2ScoreLabel.Text = (Int32.Parse(p2ScoreLabel.Text) - 1).ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                }
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            btnStartGame.Visible = false;
            Player player1 = new Player();
            player1.PlayerName = "Thing 1";
            Player player2 = new Player();
            player2.PlayerName = "Thing 2";
            Player currPlayer = null;


            //player1 turn
            bool turn = false;
            if(turn == false)
            {
                currPlayer = player1;
            }
            else
            {
                currPlayer = player2;
            }
            

            PlayerTurn(turn, currPlayer);
        }

        public void PlayerTurn(bool turn, Player currPlayer)
        {

            


            //if it is player1's turn, highlight player
            if (turn == false)
            {
                p1Panel.Visible = true;
                //newGame.ChangeTurn(turn);
               
            }

        }

        public bool CheckEnabled()
        {
            if (btnAction.Enabled == false && btnWhere.Enabled == false && btnWith.Enabled == false)
            {
                return true;
            }
            return false;
        }
    }
}
