using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleProgramming
{
    class Conditions
    {
        static void Main(string[] arg)
        {
            int a;
            Console.WriteLine("enter an integer");

            a = Int32.Parse(Console.ReadLine());
            if(a%2==0)
            {
                Console.WriteLine("number is even");
            }
            else
            {
                Console.WriteLine("num  is  odd ");
            }
            Console.ReadKey();
        }
    }
}
