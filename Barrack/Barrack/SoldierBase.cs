using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrack
{
    abstract class SoldierBase
    {
        public SoldierBase()
        {
            try
            {
                Materials.People--;
            }
            catch
            {
                Console.WriteLine("brak ludzi");
                throw new RecruitmentException();
            }
        }

        virtual public void Back()
        {
            Materials.People++;
        }
    }
}
