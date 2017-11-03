using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrack
{
    abstract class SoldierBase
    {
        protected Materials materials;
        protected int gold;

        public SoldierBase(ref Materials m, int gold = 0)
        {
            materials = m;
            this.gold = gold;
            try
            {
                materials.People--;
            }
            catch
            {
                Console.WriteLine("brak ludzi");
                throw new RecruitmentException();
            }

            try
            {
                materials.Gold -= gold;
            }
            catch
            {
                Console.WriteLine("brak złota");
                materials.People++;
                throw new RecruitmentException();
            }
        }

        virtual public void Back()
        {
            materials.People++;
            materials.Gold += gold;
        }
    }
}
