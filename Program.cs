using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";


            Console.WriteLine("Hello, Im going to calculate your first input minus your second one.....");
            Console.WriteLine();
            
            while (userInput.Length < 2)
            {
                Console.WriteLine("Please enter your character:");
                char charInput = Console.ReadKey(true).KeyChar;
                if (Char.IsLetter(charInput) || Char.IsDigit(charInput))
                {
                    userInput += charInput;
                    Console.WriteLine("Your character '" + charInput + "' numeric input is " + (int)charInput);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid key pressed");
                }
            }

            Console.WriteLine("Your reuslt is : " + ((int)userInput[0]).ToString() + " - " + ((int)userInput[1]).ToString() + " = " + ((int)userInput[0] - (int)userInput[1]));

            Console.Read();
        }

    }

}
