namespace bodyPart
{
    partial class _main 
    {
        public class UserResult
        {
            public static bool isValidNum(string input, out int result) 
            {
                bool userInputIsValid = int.TryParse(input, out result);
                return userInputIsValid;
            }

            public static bool isRightNum(int userInput, int diceResult) 
            {
                return diceResult == userInput;
            }
        }
    }

}