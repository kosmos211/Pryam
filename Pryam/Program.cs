using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pryam
{
    public class Program
    {
        public static int Plo(int a, int b)
        {
            int S;
            S = a * b;
            if (a < 0 || b < 0)
            {
                Console.WriteLine("error");

                return 0;
            }

            else
            {
                Console.WriteLine("true, S=", S);
            }
            return a * b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Plo(2, 5));
            Console.WriteLine(Plo(-3, 2));
            Console.WriteLine(Plo(2, -5));
            Console.WriteLine(Plo(-3, -2));
            Console.ReadKey();
        }
    }
}
