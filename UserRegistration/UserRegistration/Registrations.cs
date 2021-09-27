using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Registrations
    {
        /// <summary>
        /// Check the string is following pattern or not
        /// </summary>
        /// <param name="name"></param>
        public void Check(string name)
        {
            // Regex pattern
            string pattern = "^[A-Z]{1}[a-z]{4}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(name))
            {
                Console.WriteLine("Name {0} is Valid ", name);
            }
            else
            {
                Console.WriteLine("Name {0} is Invalid", name);
            }
        }
    }
}
