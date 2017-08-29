using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleProgramming
{
    class method
    {
        static void Main(string[] arg)
        {
            add();

            method m = new method();
            m.subtract();
            Console.ReadKey();
            
        }

        static void add()
        {
            int a = 5,b = 6;
            Console.WriteLine(a+b);
        }

        void subtract()
        {
            int a = 2;
            int h = 4;

            Console.WriteLine(a-h);

        }
    }
}
