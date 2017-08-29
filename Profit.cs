using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Profit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Cost Price");
            Double costprice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Sell Price");
            Double sellprice = Convert.ToDouble(Console.ReadLine());
            if (costprice > sellprice)
            {
                Console.WriteLine("You made loss\n");
                Double loss = costprice - sellprice;
                Console.WriteLine("{0}", loss);
                Console.ReadKey();
            }
            else
            {
                Double profit = sellprice - costprice;
                Console.WriteLine("You earned Profit");
                Console.WriteLine("{0}", profit);
                Console.ReadKey();
            }
            }
        }
    }

