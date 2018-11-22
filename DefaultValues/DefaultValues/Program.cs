using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultValues
{
    class Program
    {
        static void Main(string[] args)
        {
            perform("Hello", 30);
            perform("Hi");

            Console.WriteLine("");

            //named parameter
            perform(x: 40, a: "Welcome");

            Console.ReadKey();
        }

        static void perform(string a, int x=21) //default parameter
        {
            Console.WriteLine("The value of a is {0}", a);
            Console.WriteLine("The value of x is {0}", x);
        }
    }
}
