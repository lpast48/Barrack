using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrack
{
    abstract class SoldierBase
    {
        protected List<Material> _material;
        protected Materials materials;

        public SoldierBase(ref Materials m)
        {
            materials = m;
            _material = new List<Material>();
            People people = new People();
            _material.Add(people);
        }

        protected void Use()
        {
            foreach (var item in _material)
            {
                item.Validate(ref materials);
            }

            foreach (var item in _material)
            {
                item.Use(ref materials);
            }
        }
    }
}
