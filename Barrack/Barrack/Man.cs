using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrack
{
    class Man
        : SoldierBase
    {
        public Man(ref Materials m)
            : base(ref m)
        {
            Console.WriteLine("Stworzono chłopa");
        }
    }
}
