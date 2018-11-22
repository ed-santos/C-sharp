using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations_CSharp1
{
    class Program
    {//Define the Numeration    
        public enum Days { Sun=-10, Mon, Tues=15, Wed, Thur, Fri, Sat };
        static void Main(string[] args)
        {
            int x = (int)Days.Sun;
            Console.WriteLine("The Sunday is: {0} day of the week", x);

            int y = (int)Days.Mon;
            Console.WriteLine("Monday ={0}", y);

            int z = (int)Days.Tues;
            Console.WriteLine("Tuesday={0}  ", z);

            int a = (int)Days.Wed;
            Console.WriteLine("Wednesday={0}", a);
            Console.ReadKey();
        }
    }
}
