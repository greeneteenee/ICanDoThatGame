using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanDoThatGame
{
    class ActionItemDB
    {
        string item;

        ActionItemDB(string item)
        {
            this.item = item;
        }

        /// <summary>
        /// This method adds an action item to the Actionitems table (INSERT functionality)
        /// </summary>
        /// <param name="item"></param>
        public static void AddActionItem(ActionItem item)
        {
            //database connection
            GameDB db = new GameDB();

            db.ActionItems.Add(item);
            db.SaveChanges();   

        }
    }
}
