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

        public Archery(ref Materials m)
            : base(ref m)
        {
            Bow bow = new Bow();
            Gold gold = new Gold(80);

            _material.Add(bow);
            _material.Add(gold);
            base.Use();
            Console.WriteLine("Stworzono łucznika");
        }
    }
}
