using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov8
{
    class Program
    {
        /* call by reference
        static void Main(string[] args)
        {
            int a = 30;
            int b = 50;

            int result = 0;

            add(a, b, out result);
            Console.WriteLine("The addition is {0}", result);
            Console.ReadKey();
        }

        static void add(int x,int y, out int ans)
        {
            ans = x + y;
        }*/

        static void Main(string[] args)
        {
            int x = 55;
            int y = 64;

            double newX;
            double newY;

            if (NormalizePoint(x, y, out newX, out newY) == true)
                Console.WriteLine("The normalized point is {0} and {1}", newX, newY);
            else
                Console.WriteLine("The values must be between 1 to 100");

            Console.ReadKey();
        }

        static bool NormalizePoint(int x, int y, out double x1, out double y1)
        {
            x1 = 0;
            y1 = 0;

            if ((x < 1) || (x > 100))
                return false;
            if ((y < 1) || (y > 100))
                return false;

            if ((x > y))
            {
                x1 = x / (double)x;
                y1 = y / (double)x;
            }
            else
            {
                x1 = x / (double)y;
                y1 = y / (double)y;
            }
            return true;
        }
    }
}

