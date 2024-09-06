
using A3_CookiesCookbook.Class;
using A3_CookiesCookbook.Interfaces;
using System;
using System.Collections;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
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

            string filePath = "recipes.txt";//store txt file

            //print recipes
            //List<Recipe> recipes = new List<Recipe>();
            List<Recipe> recipes = LoadRecipesFromFile(filePath);

            if (recipes.Count > 0)
            {
                Console.WriteLine("Existing recipes are:\n");

                for (int i = 0; i < recipes.Count; i++)
                {
                    Console.WriteLine($"***** {i + 1} *****");
                    PrintRecipe(recipes[i]);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No recipes are yet saved in the text file.");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

            bool continueAddingRecipes = true;

            while (continueAddingRecipes)
            {
                Console.WriteLine("Create a new cookie recipe! Available ingredients are:");
                foreach (Ingredients insideListIngredients in ingredientsList)
                {
                    Console.WriteLine(insideListIngredients.id + ". " + insideListIngredients.name);
                }

                Recipe recipe = new Recipe();
                bool ifStillAddIngre = true;


                while (ifStillAddIngre)
                {

                    Console.WriteLine("Selecting ingredients for a new recipe.");
                    string selectIngredient = Console.ReadLine();

                    if (int.TryParse(selectIngredient, out int selectId))//retuen a number as id
                    {
                        Ingredients selectedIngredient = ingredientsList.FirstOrDefault(i => i.id == selectId);//get ingredient from the ingredient list 
                        if (selectedIngredient != null)//valid id
                        {
                            recipe.IngredientIDs.Add(selectId);
                        }
                        else//invalid id
                        {
                            Console.WriteLine("Invalid ingredient ID. Please try again.");
                        }
                    }
                    else // input is not a number, should stop the loop
                    {
                        if (recipe.IngredientIDs.Count > 0)
                        {
                            Console.WriteLine("Recipe added:");
                            foreach (var ingredientId in recipe.IngredientIDs)
                            {
                                Ingredients ingredient = ingredientsList.FirstOrDefault(i => i.id == ingredientId);
                                if (ingredient != null)
                                {
                                    Console.WriteLine($"{ingredient.name}: {ingredient.Getdescription()}");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("No ingredients have been selected.Recipe will not be saved.");
                        }
                        ifStillAddIngre = false;
                    }

                }

                Console.WriteLine("Do you want to add another receipe? y/n");
                string userInput = Console.ReadLine();
                continueAddingRecipes = (userInput.ToLower() == "y");

            }

            // Save recipes to a text file
            SaveRecipes(recipes, "recipes.txt");

            Console.WriteLine("Recipes saved to 'recipes.txt'. Press any key to exit.");
            Console.ReadKey();

        }

        private static void PrintRecipe(Recipe recipe)
        {

        }

        private static List<Recipe> LoadRecipesFromFile(string filePath)
        {
          
        }

        static void SaveRecipes(List<Recipe> recipes, string filename)
        {

        }


        public class Recipe
        {
            public List<int> IngredientIDs { get; set; }

            public Recipe()
            {
                IngredientIDs = new List<int>();
            }

            public Recipe(int ingredientID) : this()
            {
                IngredientIDs.Add(ingredientID);
            }


            public override string ToString()
            {
                return string.Join(",", IngredientIDs);
            }
        }


    }
}