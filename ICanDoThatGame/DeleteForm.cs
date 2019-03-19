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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PopulateActionList()
        {
            List<ActionItem> actionsList = ActionItemDB.GetActionItems();

            comboBoxActions.DataSource = actionsList;

            comboBoxActions.DisplayMember = nameof(ActionItem.ActionDescription);
        }

        private void btnDeleteAction_Click(object sender, EventArgs e)
        {
            ActionItem deleteAction = new ActionItem();

            deleteAction.ActionDescription = comboBoxActions();
        }
    }
}
