using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool play = true;

            while (play)
            {
                int num1;
                int num2;

                string answer;

                int result;

                Console.WriteLine("Please enter your first number.");

                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter your second number.");

                num2 = Convert.ToInt32(Console.ReadLine());

                System.Console.WriteLine("What type of operation would you like to do?");

                System.Console.WriteLine("Please enter a for addition, s for subtraction, d for division, or m for multiplication.");

                answer = Console.ReadLine();

                if (answer != "a" || answer !="s" || answer != "d"|| answer != "m"){
                    System.Console.WriteLine("Invalid input");
                    play = true;
                    continue; 
                }

                if (answer == "a")
                {
                    result = num1 + num2;
                }
                else if (answer == "s")
                {
                    result = num1 - num2;
                }
                else if (answer == "d")
                {
                    result = num1 / num2;
                }
                else
                {
                    result = num1 * num2;
                }

                System.Console.WriteLine(result);

                System.Console.WriteLine("Do you want to play again?");
                System.Console.WriteLine("Enter true if yes, false if no.");

                play = Convert.ToBoolean(Console.ReadLine());
            }
        } 
    }
}
