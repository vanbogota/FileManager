using System;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //rational number test
            RationalNumber num1 = new RationalNumber(7,7);
            var num2 = new RationalNumber(5,3);
            var num3 = num2;

            Console.WriteLine(num3.Equals(num2));
            Console.WriteLine(num2.Equals(num1));
            Console.WriteLine(num3.ToString());

            //complex number test
            ComplexNumber num4 = new ComplexNumber(4, 5);
            var num5 = new ComplexNumber(5, 3);
            var num6 = num5;

            Console.WriteLine(num6.Equals(num5));
            Console.WriteLine(num5.Equals(num4));
            Console.WriteLine(num6.ToString());

        }
    }
}
