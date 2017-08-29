using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goAgain = true;
            while (goAgain)
            {
                PrintTitle();
                int input = UserNumber.GetUserInteger();
                Console.WriteLine("\nThe Roman equivalent to your input is: "
                    + RomanNumber.ThousandsPlace(input)
                    + RomanNumber.HundredsPlace(input)
                    + RomanNumber.TensPlace(input)
                    + RomanNumber.OnesPlace(input));

                Console.Write("\nAgain? (Y/N): ");
                string repeat = Console.ReadLine();
                if (repeat != "Y" && repeat != "y")
                {
                    goAgain = false;
                }
            }
        }

        private static void PrintTitle()
        {
            Console.Clear();
            Console.WriteLine("Roman Numeral Generator\n\nConverts your integer to a Roman numeral!\n");
        }
    }
}
