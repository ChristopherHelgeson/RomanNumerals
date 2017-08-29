using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    class UserNumber
    {
        public static int GetUserInteger()
        {
            bool repeat = true;
            int input = 0;
            while (repeat)
            {
                Console.Write("\nPlease input an integer from 1 - 4999, inclusive: ");
                string userInput = Console.ReadLine();
                try
                {
                    input = Convert.ToInt32(userInput);
                    if (input < 0)
                    {
                        Console.WriteLine("\nThat is not a positive integer");
                    }
                    else if (input == 0)
                    {
                        Console.WriteLine("\nRomans do not have a number for zero.");
                    }
                    else if (input > 4999)
                    {
                        Console.WriteLine("\nThat number is too large for this exercise.");
                    }
                    else
                    {
                        repeat = false;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("\nThat is not an integer.");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("\nThat number is too large. Maximum value is 2147483647.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nNot sure why that input failed, but it did. Try again.");
                }
            }
            return input;
        }
    }
}
