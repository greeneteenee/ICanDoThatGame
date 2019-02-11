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
            MessageBox.Show(randomAction);
        
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
    }
}
