using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov12CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Odd or Even Program
            Console.Write("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

      
            //If version of Odd and Even
            if (num % 2 == 0)
                Console.WriteLine("The number provided is even");
            else
                Console.WriteLine("The number is odd");

            //Terinary Operator Version of above
            var result = (num % 2 == 0) ? "The Number provided is even" : "The number provided is odd";
            Console.WriteLine(result);
            */


            /*//Celcius or Farenheit
            Console.Write("Please enter the temperature number: ");
            int temp = int.Parse(Console.ReadLine());
            Console.Write("Please enter C for Celcius or F for Farenheit: ");
            char unit = Convert.ToChar(Console.ReadLine());
            double newTemp;

            if (unit == 'C' || unit == 'c')
            {
                newTemp = temp * 1.8 + 32;
                Console.WriteLine("The converted temperature is {0} Farenheit", newTemp);
            }
            else 
            {
                newTemp = (temp - 32) / 1.8;
                Console.WriteLine("The converted temperature is {0} Celcius", newTemp);
            }
            */

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
