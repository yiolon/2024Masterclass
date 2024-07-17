
using A3_CookiesCookbook.Class;
using A3_CookiesCookbook.Interfaces;
using System;
using System.Collections;
using System.Drawing;
using System.Threading.Channels;

namespace CookieCookbook
{
    class _main
    {
        static List<Ingredients> ingredientsList = new List<Ingredients>
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
            foreach (Ingredients insideListIngredients in ingredientsList)
            {
                Console.WriteLine(insideListIngredients.id + ". " + insideListIngredients.name);
            }


            bool ifStillAddIngre = true;
            List<Ingredients> receipeContainList = new List<Ingredients>();

            ArrayList receipeContainID = new ArrayList();//store receipe by id like [1,3,5]

            while (ifStillAddIngre)
            {
                
                Console.WriteLine("Selecting ingredients for a new recipe.");
                string selectIngredient = Console.ReadLine();

                if (int.TryParse(selectIngredient, out int selectId))//retuen a number as id
                {
                    Ingredients selectedIngredient = ingredientsList.FirstOrDefault(i => i.id == selectId);//get ingredient from the ingredient list 
                    if (selectedIngredient != null)//valid id
                    {
                        receipeContainList.Add(selectedIngredient);                       
                    }
                    else//invalid id
                    {
                        Console.WriteLine("Invalid ingredient ID. Please try again.");
                    }
                }
                else // input is not a number, should stop the loop
                {
                    if (receipeContainList.Count >0) 
                    {
                        Console.WriteLine("Recipe added:");                       
                        foreach (var item in receipeContainList)
                        {
                            Console.WriteLine($"{item.name}. {item.Getdescription()}");
                          
                        }

                    }
                    else
                    {
                        Console.WriteLine("No ingredients have been selected.Recipe will not be saved.");
                    }
                    ifStillAddIngre = false;
                }
                
            }

         Console.WriteLine("Press any key to exit...");
         Console.ReadKey();
        }
    }
}