using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public static int AddMethod(string input1, string input2)
        {
            //business logic
            int.TryParse(input1, out int number1);
            int.TryParse(input2, out int number2);

            var sum = number1 + number2;
            return sum;
        }
    }
}
