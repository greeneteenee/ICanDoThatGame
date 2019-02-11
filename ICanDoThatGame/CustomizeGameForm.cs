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
    public partial class CustomizeGameForm : Form
    {
        public CustomizeGameForm()
        {
            InitializeComponent();
        }

        private void btnCustomize_Click(object sender, EventArgs e)
        {
            //create variables using form TextBox inputs
            string action = txtActionItem.Text;
            string place = txtWhereItem.Text;
            string challenge = txtWithItem.Text;

            //to test add addAction code
            //ActionItem addAction = new ActionItem();
            //addAction.ActionDescription = "test1";   
                    
            //if "insert new action" textBox is not empty, add new Action to database
            if (!String.IsNullOrEmpty(action))
            {
                ActionItem addAction = new ActionItem(action);
                addAction.ActionDescription = action;

                ActionItemDB.AddActionItem(addAction);
                MessageBox.Show("Action added successfully");

            }
        }
    }
}
