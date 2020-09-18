using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2
{
    class Program
    {

        static void WorkingWithIntegers()

        {

            int a = 18;
            int b;
            b = 6;

            int c = a + b;
            Console.WriteLine(c);

            c = a * b;
            Console.WriteLine(c);

            c = a - b;
            Console.WriteLine(c);

            c = a / b;
            Console.WriteLine(c);

            int e = 5;
            int f = 4;
            int g = 2;
            int h = e + f * g;
            Console.WriteLine(h);

            Console.ReadLine();

        }

        static void OrderPrecedence()

        {

            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);

            d = (a + b) * c;
            Console.WriteLine(d);

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);

            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e + f) / g;
            Console.WriteLine(h);

            Console.ReadLine();


            //Shows that deciaml sums are rounded to int 

        }

        static void TestLimits()
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;

            Console.WriteLine($"The range of integers is from {min} to {max}");

            int what = max + 1;
            Console.WriteLine($"This is an example of an overflow {what}");

            Console.ReadLine();

        }


        static void WorkWithDoubles()
        {

            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);

            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e + f) / g;
            Console.WriteLine(h);

            double min = double.MinValue;
            double max = double.MaxValue;
            Console.WriteLine($"The range of doubles is from {min} to {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);


            Console.ReadLine();


        }

        static void WorkWithDecimals()
        {
            decimal max = decimal.MaxValue;
            decimal min = decimal.MinValue;
            Console.WriteLine($"The range of decimal values is from {min} to {max}");

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0m;
            decimal d = 3.0m;
            Console.WriteLine(c / d);

        }




        static void Main(string[] args)
        {

            WorkingWithIntegers();

            OrderPrecedence();

            TestLimits();

            WorkWithDoubles();

            WorkWithDecimals();

        }
    }
}
