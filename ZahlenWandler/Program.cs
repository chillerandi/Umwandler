using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZahlenWandler
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int num;
            string romanNum;
            if (int.TryParse(input, out num)) {
                var result = RomanNumerals.convertToRoman(num);
                Console.WriteLine(result);
                Console.Read();
            }

            if (input.Contains("I") || input.Contains("V") || input.Contains("X") ||
                    input.Contains("L") || input.Contains("C") || input.Contains("M")) {
                var result = RomanNumerals.convertToArabic(input);
                Console.WriteLine(result);
                Console.Read();
            }
        }
    }
}
