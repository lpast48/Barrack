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
        public HorseArchery(ref Materials m, int gold = 160)
            : base(ref m, gold)
        {
            try
            {
                materials.Horse--;
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
            materials.Horse++;
        }
    }
}
