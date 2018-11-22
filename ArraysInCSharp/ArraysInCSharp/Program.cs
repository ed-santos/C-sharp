using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Array one dimentional
            int[] x = { 20, 30, 66, 77, 11 };
            int i = 0;

            foreach (int num in x)
                Console.WriteLine("x[{0}] = {1}", i++, num);
                Console.WriteLine("Length is: {0}", x.Length);
                Console.WriteLine("Rank of Array is: {0}", x.Rank);

            Console.ReadKey();*/

            // 2D Array
            string[,] names = {
                { "John", "Smith"},
                { "Paige", "Marie"},
                { "Kaya", "Rey"}
            };

            foreach (string s in names)
                Console.WriteLine("The elements of String array are {0}", s);

            Console.ReadKey();
            


        }
    }
}
