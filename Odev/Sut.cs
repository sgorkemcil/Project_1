using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    class Sut : Urun, IBozulabilir
    {
        public DateTime SKT { get ; set ; }

        public string Tipi { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"{SKT}{Tipi}";
        }
    }
}
