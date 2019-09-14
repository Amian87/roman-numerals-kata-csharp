﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeral
    {
        Dictionary<int, string> arabicToNumeral = new Dictionary<int, string>
        {
            {1000, "M" },
            {900, "CM" },
            {500, "D" },
            {400, "CD" },
            {100, "C" },
            {90, "XC" },
            {50, "L" },
            {40, "XL"},
            {10, "X" },
            {9, "IX"},
            {6, "VI" },
            {5, "V" },
            {4, "IV" },
            {1, "I" }
        };


        public string ConvertToRoman(int arabic)
        {

            string roman = string.Empty;

            foreach(int value in arabicToNumeral.Keys)
            {
                while(arabic >= value)
                {
                    roman += arabicToNumeral[value];
                    arabic -= value;
                }
            }

            return roman;
        }


    }
}
