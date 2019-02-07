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
    }
}
