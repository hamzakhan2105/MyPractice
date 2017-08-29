using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleProgramming
{
    class Class1
    {
        static void Main(string[] arg)
        {
            int a = 4;
            string s = "sufyan";
            dynamic age = 20;

            Console.WriteLine(a.GetType());
            Console.WriteLine((s.ToUpper()+" " + s.GetType()));
            Console.WriteLine(age.GetType());
            Console.ReadKey();
        }
    }
}
