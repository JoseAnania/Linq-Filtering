using System;
using System.Collections.Generic;
using System.Linq;

namespace FilteringLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] mix = { 1, "string", 'd', new List<int>() { 1, 2, 3, 4 }, new List<int> { 5, 2, 3, 4 }, "dd", 's', "Hello Kitty", 1, 2, 3, 4, };

            Console.WriteLine("1) Obtener los valores INT");

            var allIntegers = mix.OfType<int>();

            Console.WriteLine(string.Join(", ", allIntegers));
            
            Console.WriteLine("---------------");

            Console.WriteLine("2) Obtener los valores STRING");

            var allStrings = mix.OfType<string>();

            Console.WriteLine(string.Join(", ", allStrings));

            Console.WriteLine("---------------");

        }
    }
}
