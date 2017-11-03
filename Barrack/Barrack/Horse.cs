using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrack
{
    class Horse
        :Material
    {
        public Horse(int q = 1) : base(q) { }
        public override void Use(ref Materials m)
        {
            m.Horse -= quantity;
        }

        public override void Validate(ref Materials m)
        {
            if (m.Horse < quantity)
            {
                Console.WriteLine("brak koni");
                throw new RecruitmentException();
            }
        }
    }
}
