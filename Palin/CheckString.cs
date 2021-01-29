using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palin
{
    public class CheckString
    {

        public Boolean letsCheck(string s)
        {
            string strim = String.Concat(s.Where(c => !Char.IsWhiteSpace(c)));

            if (strim.Length != 0)
            {
                char[] odwroc = strim.ToCharArray();
                Array.Reverse(odwroc);

                String odwString = new string(odwroc);

                if (String.Equals(strim, odwString, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Tak, jest to Palindrom.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Nie, nie jest to Palindrom");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Nie jest to palindrom");
                return false;
            }
                
            
               
        }



    }
}
