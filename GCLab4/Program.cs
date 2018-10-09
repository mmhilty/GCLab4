using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab4
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                // user prompt - enter in an integer
                

                Console.WriteLine("Learn your squares and cubes!");
                Console.WriteLine(" ");                
                Console.WriteLine("Enter an integer: ");
                var userInput = Console.ReadLine();

                double userNumber;

                if (double.TryParse(userInput, out userNumber))
                {
                    int userInteger = Convert.ToInt32(userNumber);

                    int i = 1;

                    Console.WriteLine("{0,-10:0}{1,-15:0}{2, -20:0 }", "Number", "Squared", "Cubed");
                    Console.WriteLine("{0,-10:0}{1,-15:0}{2, -20:0 }", "======", "======", "======");

                    while (i <= userInteger)
                    {
                        Console.WriteLine("{0,-10:0}{1,-15:0}{2, -20:0 }", i, i * i, i * i * i);
                        i = i + 1;
                    }

                    Console.WriteLine("Would you like to continue? Y/N");
                    string continueInput = Console.ReadLine();

                    if (continueInput.ToLower() == "n")
                    {
                        break;
                    }

                    else
                    {
                        continue;
                    }
                }

                else
                {
                    Console.WriteLine("That is not a valid input. Please try again.");
                    continue;
                }

                }

            }
        }
    }

