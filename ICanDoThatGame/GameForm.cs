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

        private void btnAction_Click(object sender, EventArgs e)
        {
    
            string randomAction = ActionItemDB.GetRandomAction();
            lblAction.Text = randomAction;
            //MessageBox.Show(randomAction);
            panelAction.Visible = true;
        
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            string randomWhere = WhereItemDB.GetRandomWhere();
            lblWhere.Text = randomWhere;
            //MessageBox.Show(randomWhere);
            panelWhere.Visible = true;
        }

        private void btnWith_Click(object sender, EventArgs e)
        {
            string randomWith = WithItemDB.GetRandomWith();
            lblWith.Text = randomWith;
            //MessageBox.Show(randomWith);
            panelWith.Visible = true;
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
            p1ScoreLabel.Text = (Int32.Parse(p1ScoreLabel.Text)+1).ToString();
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
    }
}
