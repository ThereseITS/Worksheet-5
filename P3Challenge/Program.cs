/*Worksheet 5 Part 3 : 
  Author: Therese Hume
  Date: Updated Feb 2025
  Purpose: Translate a numeric Cheque to words*/
using System.Security.Cryptography;
using Microsoft.Win32.SafeHandles;

namespace P3Challenge
{
 internal class Program
 { 
   static void Main(string[] args)
   {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double amount = 0;

            Console.WriteLine(ConvertCheque(0.50));
            Console.WriteLine(ConvertCheque(3.00));
            Console.WriteLine(ConvertCheque(5.20));
            Console.WriteLine(ConvertCheque(20.50));
            Console.WriteLine(ConvertCheque(28.50));
            Console.WriteLine(ConvertCheque(350.00));
            Console.WriteLine(ConvertCheque(4700.95));
            Console.WriteLine(ConvertCheque(90000.50));
            Console.WriteLine(ConvertCheque(123456789.50));



            Console.Write("Please enter the amount of the cheque: ");

            if (double.TryParse(Console.ReadLine(), out amount))
                {
                Console.WriteLine($"--------------------");
                Console.WriteLine($"the amount of: {amount:c}");
                Console.WriteLine($"({ConvertCheque(amount)})");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            
   }

        /// <summary>
        /// Converts an amount in euro to a text string, writing the number as words.
        ///
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        static string ConvertCheque(double amount)
            {
                int euro = (int)amount;
                int cents = (int)((amount - euro) * 100);
                if (cents == 0)
                {
                    return ConvertNumberToText(euro) + " euro";
                }
                else if (euro==0)
                {
                return ConvertNumberToText(cents) + " cents";
                }
                else
                {
                    return ConvertNumberToText(euro) + " euro and " + ConvertNumberToText(cents) + " cents";
                }
            }

            /// <summary>
            /// Converts a given number to text.
            /// </summary>
            /// <param name="amount"></param>
            /// <returns></returns>
            static string ConvertNumberToText(long amount)
            {

                string numberInWords = "";
                string[] units = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (amount < 0)
                {
                    return ("The number must be positive");
                }
                else if (amount == 0)
                {
                    numberInWords = "zero";
                }

                else if (amount < 20)
                {
                    numberInWords = units[amount];
                }

                else if (amount < 100)
                {
                    numberInWords = (tens[amount / 10] + " " + units[amount % 10]);
                }
                else if (amount < 1000)
                {
                    numberInWords = ConvertNumberToText(amount / 100) + " hundred ";

                    if (amount % 100 > 0)
                    {
                        numberInWords = numberInWords + " and " + ConvertNumberToText(amount % 100);
                    }
                }
                else if (amount < 1000000)
                {
                    numberInWords = ConvertNumberToText(amount / 1000) + " thousand";

                    if (amount % 1000 > 0)
                    {
                        numberInWords = numberInWords + " , " + ConvertNumberToText(amount % 1000);
                    }
                }
                else if (amount < 1000000000)
                {

                    numberInWords = ConvertNumberToText(amount / 1000000) + " million ";

                    if (amount % 1000000000 > 0)
                    {
                        numberInWords = numberInWords + " , " + ConvertNumberToText(amount % 1000000);
                    }
                }
                return numberInWords;
            }

 }
}

