using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrack
{
    static class Materials
    {
        static private int people = 5;
        static public int People
        {
            get
            {
                Validate();
                people--;
                return people;
            }
            set
            {
                people = value;
            }
        }

        static private int spear = 10;
        static public int Spear
        {
            get
            {
                Validate();
                spear--;
                return spear;
            }
            set
            {
                spear = value;
            }
        }
        static private int bow = 10;
        static public int Bow
        {
            get
            {
                Validate();
                bow--;
                return bow;
            }
            set
            {
                bow = value;
            }
        }
        static private int crossbow = 10;
        static public int Crossbow
        {
            get
            {
                Validate();
                crossbow--;
                return crossbow;
            }
            set
            {
                crossbow = value;
            }
        }

        static void Validate()
        {
            if (people == 0 ||
                spear == 0 ||
                bow == 0 ||
                crossbow == 0)
            {
                throw new RecruitmentException();
            }
        }
    }
}
