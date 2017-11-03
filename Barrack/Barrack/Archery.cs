using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrack
{
    class Archery
        : SoldierBase
    {
        public Archery()
        {
            try
            {
                int a = Materials.Bow;
                Console.WriteLine("Stworzono łucznika");
            }
            catch
            {
                Console.WriteLine("Brak łuków");
            }
        }
    }
}
