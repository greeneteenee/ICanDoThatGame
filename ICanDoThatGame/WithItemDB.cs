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
    }
}
