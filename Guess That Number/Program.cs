using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_That_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets Play a Game");
            GameFunction();
            Console.WriteLine("Would you Like to play again?");
            string answer = Console.ReadLine();
            string lower = answer.ToLower();
            if (lower == "yes" || lower == "y")
           {
                GameFunction();
           }
            else Console.WriteLine("It's over now");
           }
            static void GameFunction()
            {

                Console.WriteLine("I am thinking of a number.");

                Random randomNumberGenerator = new Random();
                int randomNumber = randomNumberGenerator.Next(1, 101);

                Console.WriteLine("Type in your guess, :");
                int intInput = 0;
                while (intInput != randomNumber)
                {
                    string newInput = Console.ReadLine();
                    intInput = int.Parse(newInput);
                    Console.WriteLine("no, not" + newInput);
                    if (intInput > randomNumber)
                    {
                        Console.WriteLine("your guess was too high");
                    }
                    else if (intInput < randomNumber)
                    {
                        Console.WriteLine("your guess was too low");
                    }

                }

                    Console.WriteLine(intInput + "was correct, you win!");
                    Console.ReadKey();



                }


        }
    }
