using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrack
{
    static class Materials
    {
        static private int people = 10;
        static public int People
        {
            get
            {
                if (people == 0)
                {
                    throw new RecruitmentException();
                }
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
                if (spear == 0)
                {
                    throw new RecruitmentException();
                }
                return spear;
            }
            set
            {
                spear = value;
            }
        }
        static private int bow = 5;
        static public int Bow
        {
            get
            {
                if (bow == 0)
                {
                    throw new RecruitmentException();
                }
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
                if (crossbow == 0)
                {
                    throw new RecruitmentException();
                }
                return crossbow;
            }
            set
            {
                crossbow = value;
            }
        }
        static private int horse = 10;
        static public int Horse
        {
            get
            {
                if (horse == 0)
                {
                    throw new RecruitmentException();
                }
                return horse;
            }
            set
            {
                horse = value;
            }
        }
    }
}
