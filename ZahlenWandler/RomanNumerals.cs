using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZahlenWandler
{
    public static class RomanNumerals
    {
        private static int[] VALUES = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private static String[] SYMBOLS = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        private static int convert(StringBuilder sb, int remaining, int value, String roman)
        {
            while (remaining >= value) {
                sb.Append(roman);
                remaining -= value;
            }
            return remaining;
        }

        public static String convertToRoman(int arabic)
        {
            StringBuilder sb = new StringBuilder();
            int remaining = arabic;

            for (int i = 0; i < VALUES.Length; i++) {
                remaining = convert(sb, remaining, VALUES[i], SYMBOLS[i]);
            }
            return sb.ToString();
        }
    }
}
