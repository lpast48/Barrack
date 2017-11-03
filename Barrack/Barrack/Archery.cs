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
        public Archery(ref Materials m, int gold = 80)
            :base(ref m, gold)
        {
            try
            {
                materials.Bow--;
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
            materials.Bow++;
        }
    }
}
