using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palin
{
    public class CheckString
    {

        public string letsCheck(string s)
        {
         
            string strim = s.Replace(" ", String.Empty);
            
            char[] odwroc = strim.ToCharArray();
            Array.Reverse(odwroc);

            String odwString = new string(odwroc);

            if (String.Equals(strim, odwString, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Tak, jest to Palindrom.");
                return odwString;
            }
            else
            {
                Console.WriteLine("Nie, nie jest to Palindrom");
                return s;
            }
               
        }



    }
}
