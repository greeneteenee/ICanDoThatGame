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
                                       
            //if txtActionTtem TextBox is not empty, add new Action to database
            if (!String.IsNullOrEmpty(action))
            {
                ActionItem addAction = new ActionItem(action);
                addAction.ActionDescription = action;

                ActionItemDB.AddActionItem(addAction);
                txtActionItem.Text = string.Empty;
                MessageBox.Show("Action added successfully");

            }

            //if txtWhereItem TextBox is not empty, add new Where item to database
            if (!String.IsNullOrEmpty(place))
            {
                WhereItem addWhere = new WhereItem(place);
                addWhere.WhereDescription = place;

                WhereItemDB.AddWhereItem(addWhere);
                txtWhereItem.Text = string.Empty;
                MessageBox.Show("Place added successfully");

            }

            //if txtWithItem TextBox is not empty, add new With item to database
            if (!String.IsNullOrEmpty(place))
            {
                WithItem addWith = new WithItem(challenge);
                addWith.WithDescription = challenge;

                WithItemDB.AddWithItem(addWith);
                txtWithItem.Text = string.Empty;
                MessageBox.Show("Challenge added successfully");

            }
      
        }

        private void btnDeleteGameItems_Click(object sender, EventArgs e)
        {
            DeleteForm deleteform = new DeleteForm();
            deleteform.Show();
        }
    }
}
