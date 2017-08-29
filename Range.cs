using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Let_us_C_chap3
{
    class Range
    {
        static void Main(string[] args)
        {
            int num,range = 0;
            
            Console.WriteLine("how many numbers you want to enter ?");
            num = Int32.Parse(Console.ReadLine());
            int[] array = new int[num];
            for(int i = 0;  i<array.Length;i++)
            {
                Console.WriteLine("enter {0} number in array ",i+1);
                array[i] = Int32.Parse(Console.ReadLine());
               
            }
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;


                    }
                }

            }
            range = array[array.Length - 1] - array[0];

            Console.WriteLine("so the range of the numbers is "+range);
            Console.ReadKey();
        }
    }
}
