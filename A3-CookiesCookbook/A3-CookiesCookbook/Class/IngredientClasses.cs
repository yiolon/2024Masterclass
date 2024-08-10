using A3_CookiesCookbook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_CookiesCookbook.Class
{
    public class WheatFlour : Ingredients, ISieve
    {

        public WheatFlour() { id = 1; }

        public override string name => "Wheat flour";

        public override string Getdescription() => $"{GetSieveDescription()}{base.Getdescription()}";

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
        public Chocolate() { id = 4; }

        public override string name => "Chocolate";

        public override string Getdescription() => $"{GetMeltDescription()}{base.Getdescription()}";

        private string GetMeltDescription()
        {
            return "Melt on water heat.";
        }

    }

    public class Sugar : Ingredients
    {
        public Sugar() { id = 5; }

        public override string name => "Sugar";

    }
    public class Cardamom : Ingredients, ITakeHalfTspn
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
