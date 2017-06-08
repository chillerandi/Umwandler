using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ZahlenWandler
{
    public static class RomanNumerals
    {
        private static int[] VALUES = { 1000, 500, 100, 50, 10, 5, 1 };
        private static String[] SYMBOLS = { "M", "D", "C", "L", "X", "V", "I" };
        private static List<String> SYMBOLLIST = SYMBOLS.OfType<String>().ToList();

        private static int convert(StringBuilder sb, int remaining, int value, String roman)
        {
            while (remaining >= value) {
                sb.Append(roman);
                remaining -= value;
            }
            return remaining;
        }

        /// <summary>
        /// converts arabic numbers to roman numerals
        /// </summary>
        /// <param name="arabic"></param>
        /// <returns></returns>
        public static String convertToRoman(int arabic)
        {
            StringBuilder sb = new StringBuilder();
            int remaining = arabic;

            for (int i = 0; i < VALUES.Length; i++) {
                remaining = convert(sb, remaining, VALUES[i], SYMBOLS[i]);
            }
            return sb.ToString();
        }

        /// <summary>
        /// converts roman numerals to arabic numbers
        /// </summary>
        /// <param name="roman"></param>
        /// <returns></returns>
        public static object convertToArabic(string roman)
        {
            int arabic = 0;
            int previous = 0;
            int current = 0;

            for (int i = 0; i < roman.Length; i++) {

                int index = SYMBOLLIST.IndexOf(roman[i].ToString());
                current = VALUES[index];
                if (previous < current && previous != 0) {
                    current = current - previous;
                    arabic -= previous;
                }
                arabic += current;
                previous = current;
                current = 0;
            }
            return arabic;
        }
    }
}
