
namespace bodypart
{
    class main
    {
        static void Main(string[] args)
        {
            CheckUserPath(); //check the file path inputted by user

            //read data file from path

            //Printing video games by serializing json
        }

        private static void CheckUserPath()
        {
            Console.WriteLine("Enter the name of the file you want to read:");
            try
            {
                string filePath = Console.ReadLine();
            }
            catch (NullReferenceException nullEx)
            {
                Console.WriteLine("File name cannot be null.");
            }
        }
    }
    
}
