using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_CookiesCookbook.Interfaces
{
    internal interface IMelt
    {
        string GetMeltDescription()
        {
            return "";
        }
    }

    interface ISieve
    {
        string GetSieveDescription()
        {
            return "Sieve";
        }
    }

    interface ITakeHalfTspn
    {
        string GetHalfDescription() => "Take half a teaspoon. ";
    }

}
