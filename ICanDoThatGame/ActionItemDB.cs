using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
        
        /// <summary>
        /// This method returns a list of all the "Action" items from the ActionItems table in the ICanDoThat database
        /// </summary>
        /// <returns>Returns all list of all "Action" items</returns>
        public static List<ActionItem> GetActionItems()
        {
            //database connection
            GameDB db = new GameDB();

            //select all ActionItems from database and put into list using LINQ
            List<ActionItem> allActionItems = (from ActionItems in db.ActionItems select ActionItems).ToList();
            return allActionItems;
        }

        /// <summary>
        /// This method returns the description of a random ActionItem from the list of all ActionItems
        /// </summary>
        /// <returns>Returns the description of an ActionItems (string)</returns>
        public static string GetRandomAction()
        {
            //database connection
            GameDB db = new GameDB();

            //get random ActionItem description from list of Actionitems
            Random rand = new Random();
            List<ActionItem> allActionItems = GetActionItems();
            string randomAction = (allActionItems[rand.Next(allActionItems.Count)]).ActionDescription.ToString();

            return randomAction;

        }

    }
}
