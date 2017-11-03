using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrack
{
    class Program
    {
        static void Main(string[] args)
        {
            Materials materials = new Materials();
            while (true)
            {
                try
                {
                    int a = Console.Read();
                    if (a == '1')
                    {
                        Man soldier = new Man(ref materials);
                    }
                    if (a == '2')
                    {
                        Archery soldier = new Archery(ref materials);
                    }
                    if (a == '3')
                    {
                        HorseArchery soldier = new HorseArchery(ref materials);
                    }
                    if (a == '4')
                    {
                        materials.People += 10;
                    }
                }
                catch
                {
                }
            }

        }
    }
}
