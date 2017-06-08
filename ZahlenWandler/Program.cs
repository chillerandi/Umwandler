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
            if (int.TryParse(input, out num)) {
                var result = RomanNumerals.convertToRoman(num);

                Console.WriteLine(result);
                Console.Read();
            }
        }
    }
}
