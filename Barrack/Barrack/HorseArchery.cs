using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrack
{
    class HorseArchery
        :Archery
    {
        public HorseArchery()
            : base()
        {
            try
            {
                Materials.Horse--;
                Console.WriteLine(" konnego");
            }
            catch
            {
                Console.WriteLine("Brak koni");
                base.Back();
                throw new RecruitmentException();
            }
        }

        public override void Back()
        {
            base.Back();
            Materials.Horse++;
        }
    }
}
