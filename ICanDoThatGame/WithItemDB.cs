using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanDoThatGame
{
    class WithItemDB
    {
        public static void AddWithItem(WithItem item)
        {
            //database connection
            GameDB db = new GameDB();

            db.WithItems.Add(item);
            db.SaveChanges();

        }


        /// <summary>
        /// This method returns a list of all the "With" items from the WithItems table in the ICanDoThat database
        /// </summary>
        /// <returns>Returns all list of all "With" items</returns>
        public static List<WithItem> GetWithItems()
        {
            //database connection
            GameDB db = new GameDB();

            //select all WithItems from database and put into list using LINQ
            List<WithItem> allWithItems = (from WithItems in db.WithItems select WithItems).ToList();
            return allWithItems;
        }

        /// <summary>
        /// This method returns the description of a random WithItem from the list of all WithItems
        /// </summary>
        /// <returns>Returns the description of a WithItem (string)</returns>
        public static string GetRandomWith()
        {
            //database connection
            GameDB db = new GameDB();

            //get random WithItem description from list of Withitems
            Random rand = new Random();
            List<WithItem> allWithItems = GetWithItems();
            string randomWith = (allWithItems[rand.Next(allWithItems.Count)]).WithDescription.ToString();

            return randomWith;

        }

    }
}
