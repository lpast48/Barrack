using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrack
{
    class Bow
        :Material
    {
        public Bow(int q = 1) : base(q) { }
        public override void Use(ref Materials m)
        {
            m.Bow -= quantity;
        }

        public override void Validate(ref Materials m)
        {
            if (m.Bow < quantity)
            {
                Console.WriteLine("brak łuków");
                throw new RecruitmentException();
            }
        }
    }
}
