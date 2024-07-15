
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

            Console.WriteLine("Selecting ingredients for a new recipe.");
            Console.ReadKey();

        }



        

        public class Ingredients
        {
            public int id;
            public virtual string name=>"";
            public virtual string Getdescription() => "Add to other ingredients.";
        }

        public class WheatFlour : Ingredients, ISieve
        {

            public WheatFlour() {id = 1; }

            public override string name => "Wheat flour";

            public override string Getdescription()=> $"{GetSieveDescription()}{base.Getdescription()}";

            private string GetSieveDescription()
            {
                return "Sieve";
            }
        }

        public class CoconutFlour : Ingredients, ISieve
        {
            public CoconutFlour() { id = 2; }

            public override string name => "Coconut flour";

            public override string Getdescription() => $"{GetSieveDescription()}{base.Getdescription()}";

            private string GetSieveDescription()
            {
                return "Sieve";
            }
        }

        public class Butter : Ingredients, IMelt
        {
            public Butter() { id = 3; }

            public override string name => "Butter";

            public override string Getdescription() => $"{GetMeltDescription()}{base.Getdescription()}";

            private string GetMeltDescription()
            {
                return "Melt on low heat.";
            }
        }

        public class Chocolate : Ingredients, IMelt
        {  //public () { int id = ; }
            public Chocolate() { id =4 ;}

        public override string name => "Chocolate";

            public override string Getdescription() => $"{GetMeltDescription()}{base.Getdescription()}";

            private string GetMeltDescription()
            {
                return "Melt on water heat.";
            }

        }

        public class Sugar : Ingredients
        {
            public Sugar() { id = 5;}

        public override string name => "Sugar";

        }
        public class Cardamom : Ingredients,ITakeHalfTspn
        {
            public Cardamom() { id = 6; }

            public override string name => "Cardamom";

            public override string Getdescription() => $"{GetHalfDescription()}{base.Getdescription()}";

            private string GetHalfDescription()
            {
                return "Take half a teaspoon.";
            }

        }

        public class Cinnamon : Ingredients, ITakeHalfTspn
        {
            public Cinnamon() { id = 7; }

            public override string name => "Cinnamon";

            public override string Getdescription() => $"{GetHalfDescription()}{base.Getdescription()}";

            private string GetHalfDescription()
            {
                return "Take half a teaspoon.";
            }

        }
        public class CocoaPowder : Ingredients
        {
            public CocoaPowder() { id = 8; }

            public override string name => "Cocoa powder";

        }
     







       


    }
}