using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleProgramming
{
    class factorial
    {
        static void Main(string[] arg)
        {
            int a, fact = 1;
            Console.WriteLine("enter a number ");
            a = Int32.Parse(Console.ReadLine());

            for(int i = 1;i<=a;i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("factorial is "+fact);

            Console.ReadKey();
        }
    }
}
