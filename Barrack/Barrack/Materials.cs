using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrack
{
    class Materials
    {
        private int people = 10;
        private int spear = 10;
        private int bow = 20;
        private int crossbow = 10;
        private int horse = 10;
        private int gold = 1000;

        public int People
        {
            get
            {
                return people;
            }
            set
            {
                if (value < 0)
                {
                    throw new RecruitmentException();
                }
                people = value;

            }
        }

        public int Spear
        {
            get
            {
                return spear;
            }
            set
            {
                if (value < 0)
                {
                    throw new RecruitmentException();
                }
                spear = value;
            }
        }

        public int Bow
        {
            get
            {
                return bow;
            }
            set
            {
                if (value < 0)
                {
                    throw new RecruitmentException();
                }
                bow = value;
            }
        }

        public int Crossbow
        {
            get
            {
                return crossbow;
            }
            set
            {
                if (value < 0)
                {
                    throw new RecruitmentException();
                }
                crossbow = value;
            }
        }

        public int Horse
        {
            get
            {
                return horse;
            }
            set
            {
                if (value < 0)
                {
                    throw new RecruitmentException();
                }
                horse = value;
            }
        }

        public int Gold
        {
            get
            {
                return gold;
            }
            set
            {
                if (value < 0)
                {
                    throw new RecruitmentException();
                }
                gold = value;
            }
        }
    }
}
