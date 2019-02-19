using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanDoThatGame
{
    using System;
    using System.Collections.Generic;

    public partial class WithItem
    {
        private string challenge;

        //no arg constructor
        public WithItem() { }

        public WithItem(string challenge)
        {
            this.challenge = challenge;
        }

    }
}
