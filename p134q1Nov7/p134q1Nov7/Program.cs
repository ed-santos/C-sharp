using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p134q1Nov7
{
    class Program
    {
       
        static void Main(string[] args)
        {
            double fahrenheit;
            Console.Write("Enter Celcius temperature : ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            fahrenheit = (celsius *9/5) +32;
            double answer = Math.Round(fahrenheit, 1); 
            Console.WriteLine("The converted Farenheit temperature is: " + answer);
            Console.ReadLine();
        }
    }
}
