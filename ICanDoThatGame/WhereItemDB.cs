using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanDoThatGame
{
    class WhereItemDB
    {
        public static void AddWhereItem(WhereItem item)
        {
            //database connection
            GameDB db = new GameDB();

            db.WhereItems.Add(item);
            db.SaveChanges();

        }


        /// <summary>
        /// This method returns a list of all the "Where" items from the WhereItems table in the ICanDoThat database
        /// </summary>
        /// <returns>Returns all list of all "Where" items</returns>
        public static List<WhereItem> GetWhereItems()
        {
            //database connection
            GameDB db = new GameDB();

            //select all WhereItems from database and put into list using LINQ
            List<WhereItem> allWhereItems = (from WhereItems in db.WhereItems select WhereItems).ToList();
            return allWhereItems;
        }

        /// <summary>
        /// This method returns the description of a random WhereItem from the list of all WhereItems
        /// </summary>
        /// <returns>Returns the description of a WhereItem (string)</returns>
        public static string GetRandomWhere()
        {
            //database connection
            GameDB db = new GameDB();

            //get random WhereItem description from list of Whereitems
            Random rand = new Random();
            List<WhereItem> allWhereItems = GetWhereItems();
            string randomWhere = (allWhereItems[rand.Next(allWhereItems.Count)]).WhereDescription.ToString();

            return randomWhere;

        }

    }
}
