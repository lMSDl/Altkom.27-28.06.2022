using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class NumbersDemo
    {

        public void Run()
        {
            int a = 17;
            int b = 10;
            int c = 5;

            int d = a - 3 * c + a * b;

            Console.WriteLine($"a = {a}; b = {b}; c = {c}");
            Console.WriteLine($"a - 3 * c + a * b = {d}");

            int e = c + c * c;
            Console.WriteLine($"c + c * c = {e}");


            float f = a / b;
            Console.WriteLine($"a / b = {f}");

            int g =  (int)Math.Round(6 * 0.25, MidpointRounding.AwayFromZero);
            Console.WriteLine($"6 * 0.25 = {g}");

            double h = 3.3333;
            long i = long.MaxValue;

            i = a; //niejawne rzutowanie z typu o mniejszej prezycji na typ o większej precyzji
            a = (int)i; //jawne rzutowanie na typ o mniejszej prezycji

            h = f;
            f = (float)h;

            Console.WriteLine("Podaj wartość a:");
            string value =  Console.ReadLine();
            a = int.Parse(value);


            Console.WriteLine("Podaj wartość b:");
            value = Console.ReadLine();
            b = int.Parse(value);

            Console.WriteLine("Podaj wartość f:");
            value = Console.ReadLine();
            f = float.Parse(value);


            Console.WriteLine($"a + b + f = {a+b+f}");
        }
    }
}
