using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    class RomanNumber
    {
        public static string OnesPlace(int input)
        {
            int onesValue = input % 10;
            string[] ones = new string[]
            {
                "",     //0
                "I",    //1
                "II",   //2
                "III",  //3
                "IV",   //4
                "V",    //5
                "VI",   //6
                "VII",  //7
                "VIII", //8
                "IX",   //9
            };
            string result = ones[onesValue];
            return result;
        }

        public static string TensPlace(int input)
        {
            int tensValue = (input / 10) % 10;
            string[] tens = new string[]
            {
                "",     //0
                "X",    //10
                "XX",   //20
                "XXX",  //30
                "XL",   //40
                "L",    //50
                "LX",   //60
                "LXX",  //70
                "LXXX", //80
                "XC",   //90
            };
            string result = tens[tensValue];
            return result;
        }

        public static string HundredsPlace(int input)
        {
            int hundredsValue = (input / 100) % 10;
            string[] hundreds = new string[]
            {
                "",     //0
                "C",    //100
                "CC",   //200
                "CCC",  //300
                "CD",   //400
                "D",    //500
                "DC",   //600
                "DCC",  //700
                "DCCC", //800
                "CM",   //900
            };
            string result = hundreds[hundredsValue];
            return result;
        }

        public static string ThousandsPlace(int input)
        {
            int thousandsValue = (input / 1000) % 10;
            string[] thousands = new string[]
            {
                "",     //0
                "M",    //1000
                "MM",   //2000
                "MMM",  //3000
                "MMMM",   //4000
            };
            string result = thousands[thousandsValue];
            return result;
        }
    }
}
