using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Let_us_C_chap3
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact = 1;

            Console.WriteLine("enter a number ");

            int a = Int32.Parse(Console.ReadLine());

            for(int i = 1;i<=a; i++)
            {
                fact *= i;
            }

            Console.WriteLine("ans is " + fact);
        }
    }
}
