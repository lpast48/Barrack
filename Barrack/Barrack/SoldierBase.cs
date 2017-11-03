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

        public SoldierBase(ref Materials m)
        {
            materials = m;
            try
            {
                materials.People--;
            }
            catch
            {
                Console.WriteLine("brak ludzi");
                throw new RecruitmentException();
            }
        }

        virtual public void Back()
        {
            materials.People++;
        }
    }
}
