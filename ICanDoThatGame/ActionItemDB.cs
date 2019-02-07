using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanDoThatGame
{
    static class ActionItemDB
    {

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
