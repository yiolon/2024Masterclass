using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace bodyPart
{
    partial class _main 
    {
        static void Main(string[] args)
        {
            RandomUtil random = new RandomUtil();
            int diceResult = random.RandomNumGenerater();

            //Console.WriteLine($"number is : {diceResult}");

            Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");

            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine("Enter number: ");
                string userInput = Console.ReadLine();
                bool nextStep = UserResult.isValidNum(userInput,out int userResult);

                if (nextStep) 
                {
                    if (UserResult.isRightNum(userResult, diceResult)==true)
                    {
                        Console.WriteLine("You win");
                        break;
                    }
                    else 
                    { 
                        Console.WriteLine("Wrong number");
                        continue;
                    }
                }else { Console.WriteLine("Incorrect input"); }
            }
 
            

        }
    }

}