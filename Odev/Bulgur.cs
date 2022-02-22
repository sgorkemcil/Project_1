using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    class Bulgur : Urun, ITETT
    {
        public DateTime TETT { get; set ; }

        public override string ToString()
        {
            return base.ToString() + $"{TETT}";
        }
    }
}
