using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleProgramming
{
    class PassingArray
    {
        static void Main(string[] arg)
        {
            int[] array = { 2, 4, 56, 7, 5 };
            PassArray(array);
            Console.ReadKey();
        }
        static void PassArray(int[] array)
        {
            foreach(var a in array)
            {
                Console.WriteLine(a);
            }

        }
    }
}
