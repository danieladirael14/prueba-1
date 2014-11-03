using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deber
{
    class Program
    {

        private const int constante = 5;
        static void Main(string[] args)
        {
            
    int sum = 0, acum = 0;

            for (int i = 1; i <= 11; i++)

            {

                if (i%2 != 0)

                {

                    sum = constante + i;

                    acum = sum +acum;

                    Console.WriteLine("{0} + {1} = {2}",constante,i,sum );   

                }

            }

            acum = sum + acum;

            Console.WriteLine("la suma de la serie es: {0}", acum);

            Console.ReadLine();

            Console.BackgroundColor=ConsoleColor.DarkBlue;
        }

        }
    }

