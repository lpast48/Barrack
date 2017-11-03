using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrack
{
    class People
        :Material
    {
        public People(int q = 1) : base(q) { }
        public override void Use(ref Materials m)
        {
            m.People -= quantity;
        }

        public override void Validate(ref Materials m)
        {
            if (m.People < quantity)
            {
                Console.WriteLine("brak ludzi");
                throw new RecruitmentException();
            }
        }
    }
}
