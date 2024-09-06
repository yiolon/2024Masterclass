using CookieCookbook.DataAccess;
using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook.Recipes;

public class RecipesRepository : IRecipesRepository
{
    private readonly IStringsRepository _stringsRepository;
    private readonly IIngredientsRegister _ingredientsRegister;
    private const string Separator = ",";

    public RecipesRepository(
        IStringsRepository stringsRepository,
        IIngredientsRegister ingredientsRegister)
    {
        _stringsRepository = stringsRepository;
        _ingredientsRegister = ingredientsRegister;
    }

    public List<Recipe> Read(string filePath)
    {
        List<string> recipesFromFile = _stringsRepository.Read(filePath);

        return recipesFromFile.Select(RecipeFromString).ToList();
  /*      var recipes = new List<Recipe>();

        foreach (var recipeFromFile in recipesFromFile)
        {
            var recipe = RecipeFromString(recipeFromFile);
            recipes.Add(recipe);
        }

        return recipes;*/
    }

    private Recipe RecipeFromString(string recipeFromFile)
    {
        var textualIds = recipeFromFile.Split(Separator);

        var ingredients = textualIds
       .Select(textualId => int.Parse(textualId))
       // Parse each textual ID to an integer
       .Select(id => _ingredientsRegister.GetById(id)) 
       // Get the Ingredient by ID
       .ToList(); // Materialize the results into a List<Ingredient>

        // Return a new Recipe created with the list of Ingredients
        return new Recipe(ingredients);
        
    /*    var ingredients = new List<Ingredient>();

        foreach (var textualId in textualIds)
        {
            var id = int.Parse(textualId);
            var ingredient = _ingredientsRegister.GetById(id);
            ingredients.Add(ingredient);
        }

        return new Recipe(ingredients);*/
    }

    public void Write(string filePath, List<Recipe> allRecipes)
    {
        var recipesAsStrings = allRecipes
        .Select(recipe => string.Join(Separator,
            recipe.Ingredients.Select(ingredient => ingredient.Id))) 
        .ToList();

        _stringsRepository.Write(filePath, recipesAsStrings);
        /* var recipesAsStrings = new List<string>();

         foreach (var recipe in allRecipes)
         {
             var allIds = new List<int>();
             foreach (var ingredient in recipe.Ingredients)
             {
                 allIds.Add(ingredient.Id);
             }
             recipesAsStrings.Add(string.Join(Separator, allIds));
         }

         _stringsRepository.Write(filePath, recipesAsStrings);*/
    }
}
