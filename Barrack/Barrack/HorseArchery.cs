using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrack
{
    class HorseArchery
        :SoldierBase
    {
        public HorseArchery(ref Materials m)
            : base(ref m)
        {
            Bow bow = new Bow();
            Horse horse = new Horse();
            Gold gold = new Gold(160);

            _material.Add(bow);
            _material.Add(horse);
            _material.Add(gold);
            base.Use();
            Console.WriteLine("Stworzono łucznika konnego");
        }
    }
}
