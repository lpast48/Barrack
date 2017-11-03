﻿using System;
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
            :base()
        {
            try
            {
                Materials.Bow--;
                Console.Write("Stworzono łucznika");
            }
            catch
            {
                Console.WriteLine("Brak łuków");
                base.Back();
                throw new RecruitmentException();
            }
        }

        public override void Back()
        {
            base.Back();
            Materials.Bow++;
        }
    }
}
