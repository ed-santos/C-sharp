using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int testValue = 1;
            Console.WriteLine("Original value is {0}", testValue);
            TestCallByValue(testValue);
            Console.WriteLine("After calling TestByValue the vale is {0}", testValue);
            

            Console.WriteLine("\n");
            //call by reference - using ref keyword
            Console.WriteLine("Original value is {0}", testValue);
            TestRef(ref testValue);
            Console.WriteLine("After return from TestRef() {0}", testValue);

            Console.WriteLine("\n");
            //call by reference - using out keyword
            int testValue2 = 120;
            Console.WriteLine("The Original value is{0}", testValue2);
            TestOut(out testValue2);
            Console.WriteLine("After return from TestOut() the Value is {0}", testValue2);

            Console.ReadKey();
        }

        static void TestCallByValue(int aValue)
        {
            aValue = 50;
            Console.WriteLine("Inside TestCallByValue the value is {0}", aValue);
        }

        static void TestRef(ref int aValue)
        {
            aValue = 100;
            Console.WriteLine("Inside TestRef the value is {0}", aValue);
        }

        static void TestOut(out int aValue)
        {
            aValue = 500;
            Console.WriteLine("Inside TestOut the value is {0}", aValue);
        }
    }

}
