using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter hte Integer ");
            int val= Convert.ToInt32(Console.ReadLine());
            if ( val%2==0)
            {
                Console.WriteLine("Enterred Number Is Even");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Entered Number Is Odd");
                Console.ReadKey();
            }
        }
    }
}
