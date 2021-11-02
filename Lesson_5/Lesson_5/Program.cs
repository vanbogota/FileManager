using System;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumber num1 = new RationalNumber(5,3);
            var num2 = new RationalNumber(5,3);
            var num3 = num2;


            Console.WriteLine(num3.Equals(num2));
            Console.WriteLine(num2.Equals(num1));

        }
    }
}
