using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleProgramming
{
    class Enum
    {


        static void Main(string[] arg)
        {
            string name;
            Gender gender ;

            Console.WriteLine("please enter your name");
            name = Console.ReadLine();

            Console.WriteLine(" 0 Male, 1 Female");

            int index = int.Parse(Console.ReadLine());

            gender = (Gender)index;

            Console.WriteLine("my name is {0} and my gender is {1}", name, gender);
            Console.ReadKey();

        }
        enum Gender {Male,Female }
    }
}
