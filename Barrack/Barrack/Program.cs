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
            while (true)
            {
                try
                {
                    int a = Console.Read();
                    if (a == '1')
                    {
                        Man soldier = new Man();
                    }
                    if (a == '2')
                    {
                        Archery soldier = new Archery();
                    }
                    if (a == '3')
                    {
                        Archery soldier = new HorseArchery();
                    }
                }
                catch
                {
                    Console.WriteLine("błąd");
                }

            }

        }
    }
}
