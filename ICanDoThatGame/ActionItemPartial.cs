﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanDoThatGame
{
    using System;
    using System.Collections.Generic;

    public partial class ActionItem
    {
        private string action;

        //no arg constructor
        public ActionItem() {}

        public ActionItem(string action)
        {
            this.action = action;
        }

    }
}
