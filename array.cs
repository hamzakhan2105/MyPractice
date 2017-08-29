using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleProgramming
{
    class array
    {
         static void Main(string[] ar)
        {

            int[] array = { 1, 2, 3, 4, 8, 7, 4, 5, 9 };

            foreach(int a in array)
            {
                Console.WriteLine(a);
                
            }
            Console.ReadKey();
        }
    }
}
