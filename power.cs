using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Let_us_C_chap3
{
    class power
    {
        static void Main(string[] args)
        {
            int power= 1;
            Console.WriteLine("enter a number and its exponent");
            int number = Convert.ToInt32(Console.ReadLine());
            int exp = Int32.Parse(Console.ReadLine());

            for(int i = 1;i<=exp;i++)
            {
                power *= number;

            }
            Console.WriteLine("{0}th power of the {1} is {2}",exp,number,power);
            Console.ReadKey();
        }
    }
}
