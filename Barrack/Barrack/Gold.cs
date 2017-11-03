using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrack
{
    class Gold
        :Material
    {
        public Gold(int q = 0) : base(q) { }
        public override void Use(ref Materials m)
        {
            m.Gold-=quantity;
        }

        public override void Validate(ref Materials m)
        {
            if (m.Gold < quantity)
            {
                Console.WriteLine("brak złota");
                throw new RecruitmentException();
            }
        }
    }
}
