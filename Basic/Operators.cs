using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Operators
    {
        static void Main(string[] args)
        {
            int num1 = 12;
            int num2 = 15;
            int num3 = 23;

            //Airthmetic
            Console.WriteLine(num1+num2);
            Console.WriteLine(num2-num1);
            Console.WriteLine(num1*num2);
            Console.WriteLine(num1/num2);

            // Relational - >,<,>=,<=
            Console.WriteLine(num1 > num2);
            Console.WriteLine(num1 < num2);
            Console.WriteLine(num1 >= num2);
            Console.WriteLine(num1 <= num2);
            Console.WriteLine(num1 <= num2);
            Console.WriteLine(num1 == num2);
            Console.WriteLine(num1 != num2);

           // Logical 
           Console.WriteLine(num1 <= num2 && num1 <= num3);
           Console.WriteLine(num1 >= num2 || num1 <= num3);
        }
    }
}
