

class main
{

static void Main(string[] args)
    {
        string filePath = CheckUserPath(); //check the file path inputted by user

        ReadFromPath();//read data file from path

        //Printing video games by serializing json
    }

    public static string CheckUserPath()
    {
        string filePath = null;

        while (true) 
        {
            Console.WriteLine("Enter the name of the file you want to read:");
            try
            {               
                filePath = Console.ReadLine();
                if (filePath == null)
                {
                    throw new NullReferenceException("File name cannot be null.");
                }
                else if (string.IsNullOrEmpty(filePath))
                {
                    throw new ArgumentNullException("File name cannot be empty.");
                }
                else if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("File not found.");
                }

                return filePath;
            }

            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            { 
                Console.WriteLine(ex.Message); 
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message); 
            }
        }

    }

    private static void ReadFromPath()
    {
        throw new NotImplementedException();
    }
}
  
