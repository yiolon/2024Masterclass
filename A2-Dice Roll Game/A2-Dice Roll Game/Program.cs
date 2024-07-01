using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace bodyPart
{
    class _main 
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
                    if (userResult == diceResult){
                        Console.WriteLine("You win");
                    }
                    else 
                    { 
                        Console.WriteLine("Wrong number");
                        continue;
                    }
                }else { Console.WriteLine("Incorrect input"); }
            }
 
            

        }

        public class RandomUtil
        {
            private Random random = new Random();
            public int RandomNumGenerater()
            {
                int randomNum = random.Next(1, 7);
                return randomNum;
            }
        }

        public class UserResult
        {
            public static bool isValidNum(string input, out int result) 
            {
                bool userInputIsValid = int.TryParse(input, out result);
                return userInputIsValid;
            }

            public bool isRightNum(int userInput, int diceResult) 
            {
                if (diceResult == userInput) { return true; }
                else { return false; }
            }
        }
    }

}