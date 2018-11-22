using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.FirstName = "Edward";
            p.LastName = "Santos";

            Console.WriteLine("The name is {0} {1}", p.FirstName, p.LastName);

            Console.WriteLine("The person's full name is: {0}" +
                "", p.FullName);

            Console.ReadKey();
        }
    }
}
