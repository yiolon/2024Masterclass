
using A3_CookiesCookbook.Class;
using A3_CookiesCookbook.Interfaces;
using System.Drawing;
using System.Threading.Channels;

namespace CookieCookbook
{
    class _main
    {
        static List<Ingredients> _ingredients = new List<Ingredients>
        {
            new WheatFlour(),
            new CoconutFlour(),
            new Butter(),
            new Chocolate(),
            new Sugar(),
            new Cardamom(),
            new Cinnamon(),
            new CocoaPowder()
        };
        static void Main(string[] args)
        {
            //print recipes

            Console.WriteLine("Create a new cookie recipe! Available ingredients are:");
            foreach (Ingredients insideListIngredients in _ingredients)
            {
                Console.WriteLine(insideListIngredients.id +". "+ insideListIngredients.name);
                
            }

    
      
            
            bool ifStillAddIngre = true;

            while (ifStillAddIngre) 
            {
                List<Ingredients> receipeContainList = new List<Ingredients>();

                Console.WriteLine("Selecting ingredients for a new recipe.");
                string selectIngredient = Console.ReadLine();

                switch (selectIngredient)
                {
                    case "1":
                        receipeContainList.Add(new WheatFlour());
                        Console.WriteLine("Add an ingredient by it's id or type anything else if finished.");
                        break;
                    case "2":
                        receipeContainList.Add(new CoconutFlour());
                        Console.WriteLine("Add an ingredient by it's id or type anything else if finished.");
                        break;
                    case "3":
                        receipeContainList.Add(new Butter());
                        Console.WriteLine("Add an ingredient by it's id or type anything else if finished.");
                        break;
                    case "4":
                        receipeContainList.Add(new Chocolate());
                        Console.WriteLine("Add an ingredient by it's id or type anything else if finished.");
                        break;
                    case "5":
                        receipeContainList.Add(new Sugar());
                        Console.WriteLine("Add an ingredient by it's id or type anything else if finished.");
                        break;
                    case "6":
                        receipeContainList.Add(new Cardamom());
                        Console.WriteLine("Add an ingredient by it's id or type anything else if finished.");
                        break;
                    case "7":
                        receipeContainList.Add(new Cinnamon());
                        Console.WriteLine("Add an ingredient by it's id or type anything else if finished.");
                        break;
                    case "8":
                        receipeContainList.Add(new CocoaPowder());
                        Console.WriteLine("Add an ingredient by it's id or type anything else if finished.");
                        break;
                    default:                
                        Console.WriteLine("No ingredients have been selected. Recipe will not be saved.");

                        ifStillAddIngre = false;
                        break;
                }

                if (receipeContainList.Count > 0)
                {
                    Console.WriteLine("Recipe added:");
                    foreach (var item in receipeContainList)
                    {
                        Console.WriteLine($"{item.name}. {item.Getdescription()}");
                    }
                }


            }
            
        }
            

    }
}