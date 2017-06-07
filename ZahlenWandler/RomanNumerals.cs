using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZahlenWandler
{
    public class RomanNumerals
    {
        public static long[] VALUES = { 1000, 900, 500, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        public static String[] SYMBOLS = { "M", "CM", "D", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        private static long convert(StringBuilder sb, long remaining, long value, String roman)
        {
            while (remaining >= value) {
                sb.Append(roman);
                remaining -= value;
            }
            return remaining;
        }

        public String convertToRoman(long arabic)
        {
            StringBuilder sb = new StringBuilder();
            long remaining = arabic;

            for (long i = 0; i < VALUES.Length; i++) {
                remaining = convert(sb, remaining, VALUES[i], SYMBOLS[i]);
            }
            return sb.ToString();
        }
    }
}
