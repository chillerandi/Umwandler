using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ZahlenWandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte entweder eine arabische Zahl oder eine römische Ziffer eingeben. Der gültige Wertebereich ist 1 - 3999");
            string input = Console.ReadLine();
            Match arabMatch = Regex.Match(input, "^[0-9]{1,4}$");
            Match romanMatch = Regex.Match(input, "^M{0,4}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$");
            int num;

            if (arabMatch.Success) {
                if (int.TryParse(input, out num) && num <= 3999) {
                    var result = RomanNumerals.convertToRoman(num);
                    Console.WriteLine("Sie haben die arabische Zahl " + input + " eingegeben.");
                    Console.WriteLine("Die römische Entsprechung ist : " + result);
                    Console.Read();
                }
            }
            else if (romanMatch.Success) {
                var result = RomanNumerals.convertToArabic(input);
                Console.WriteLine("Sie haben die römische Zahl " + input + " eingegeben.");
                Console.WriteLine("Die arabische Entsprechung ist : " + result);
                Console.Read();
            }
            else {
                Console.WriteLine("Bitte entweder eine arabische Zahl oder eine römische Ziffer zwischen 1 und 3999 eingeben. Bitte überprüfen Sie Ihre Eingabe.");
            }

        }
    }
}
