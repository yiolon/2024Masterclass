using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_CookiesCookbook.Class
{
    public class Ingredients
    {
        public int id;
        public virtual string name => "";
        public virtual string Getdescription() => "Add to other ingredients.";
    }
}
