using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZahlenWandler
{
    class Program
    {
        private static RomanNumerals romanNumerals;

        static void Main(string[] args)
        {
            romanNumerals = new RomanNumerals();
            long num = Int64.Parse(args[0]);
            var result = romanNumerals.convertToRoman(num);
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
