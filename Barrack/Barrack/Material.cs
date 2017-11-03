using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrack
{
    abstract class Material
    {
        protected int quantity;

        public Material(int q = 1)
        {
            quantity = q;
        }

        public abstract void Use(ref Materials m);
        public abstract void Validate(ref Materials m);
    }
}
