

using Newtonsoft.Json;
using System.Reflection.PortableExecutable;

class main
{

static void Main(string[] args)
    {
        string filePath = CheckUserPath(); //check the file path inputted by user

        List<Game> games = ReadFromPath(filePath);//read data file from path

        PrintGameList(games);//Printing video games by serializing json

        Console.WriteLine("Press any key to close.");
        Console.ReadKey();
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

    public static List<Game> ReadFromPath(string filePath)
    {
        using StreamReader reader = new StreamReader(filePath);
        var json = reader.ReadToEnd();
        try 
        {           
            List<Game> gameList = JsonConvert.DeserializeObject<List<Game>>(json);
            return gameList;
        }
        catch (JsonException ex)//invalid format
        {
            Console.WriteLine($"JSON in the {filePath} was not in a valid format. ");
            Console.WriteLine(" JSON body:");
            Console.WriteLine(json);
            Console.WriteLine("Sorry! The application has experienced an unexpected error and will have to be closed.");
            logException(ex, filePath);
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Sorry! The application has experienced an unexpected error and will have to be closed.");
            logException(ex, filePath);
            return null;
        }
        finally
        {
            // Ensure the reader is closed and resources are released
            if (reader != null)
            {
                reader.Close();
            }
        }

        //throw new NotImplementedException();
    }

    private static void PrintGameList(List<Game> games)  
    {
        if (games == null || games.Count == 0)
        {
            //throw new ArgumentNullException("");
            Console.WriteLine("No games to display.");
            return;
        }


        foreach (var item in games)
        {
            Console.WriteLine("Title: "+item.title);
            Console.WriteLine("Release Year: " + item.releaseYear );
            Console.WriteLine("Rating: " +item.rating);
            Console.WriteLine();
        }
         
    }

    private static void logException(Exception ex, string filePath)
    {
        string logFilePath = "error_log.txt";
        string logMessage = $"{DateTime.Now}: Error with file \"{Path.GetFileName(filePath)}\"\n{ex.Message}\n{ex.StackTrace}\n";
        File.AppendAllText(logFilePath, logMessage);
    }

    public class Game
    {
        public string title { get; set; }
        public int releaseYear {  get; set; }
        public float rating { get; set; }
    }
}
  
