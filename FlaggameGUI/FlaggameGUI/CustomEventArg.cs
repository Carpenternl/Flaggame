using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaggameGUI
{
    public class CustomEventArg
    {
        public Boolean result { get; set; }

        public CustomEventArg(bool result)
        {
            this.result = result;
        }
    }
}
