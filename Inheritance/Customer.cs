using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Customer
    {
        public int ToplamSatis { get; set; }
        public int IndirimOrani { get; set; }

        public int AlinacakUcret()
        {
            return 100;
        }

    }
}
