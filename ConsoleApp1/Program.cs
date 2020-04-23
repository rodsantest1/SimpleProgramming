using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.Write("What is your first number? ");
            var input1 = Console.ReadLine();
            Console.Write("What is your second number? ");
            var input2 = Console.ReadLine();

            //business
            int sum = ClassLibrary1.Class1.AddMethod(input1, input2);

            //output
            Console.WriteLine($"{input1}+{input2}={sum}");

        }

    }
}
