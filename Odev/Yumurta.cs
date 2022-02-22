using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    class Yumurta : Urun, IKirilabilir,IBozulabilir
    {
        public bool Kirik { get; set ; }
        public DateTime SKT { get ; set ; }

        public override string ToString()
        {
            return base.ToString() + $"{SKT}{Kirik}";
        }
    }
}
