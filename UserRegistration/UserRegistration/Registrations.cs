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
        /// <param name="name">first name</param>
        public bool FirstName(string name)
        {
            // Regex pattern
            string pattern = "^[A-Z]{1}[a-z]{3,}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(name))
            {
                Console.WriteLine("Name {0} is Valid ", name);
            }
            else
            {
                Console.WriteLine("Name {0} is Invalid", name);
            }
            return regex.IsMatch(name);
        }

        /// <summary>
        /// Last name is in following pattern
        /// </summary>
        /// <param name="name">last name</param>
        public bool LastName(string name)
        {
            // Regex pattern
            string pattern = "^[A-Z]{1}[a-z]{3,}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(name))
            {
                Console.WriteLine("Name {0} is Valid ", name);
            }
            else
            {
                Console.WriteLine("Name {0} is Invalid", name);
            }
            return regex.IsMatch(name);
        }

        /// <summary>
        /// Email is in following pattern
        /// </summary>
        /// <param name="mail"></param>
        public bool Email(string mail)
        {
            //regex pattern is created to check validity
            string pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex regex = new Regex(pattern);
            // IsMatch method check the pattern and mail
            if (regex.IsMatch(mail))
            {
                Console.WriteLine("Email :{0} is Valid", mail);
            }
            else
            {
                Console.WriteLine("Email :{0} is Invalid", mail);
            }
            return regex.IsMatch(mail);
        }

        /// <summary>
        /// Phone Number is in following pattern
        /// </summary>
        /// <param name="num"></param>
        public bool PhoneNumber(string num)
        {
            string pattern = @"^[1-9]{2}"+" "+"[1-9]{1}[0-9]{9}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(num))
            {
                Console.WriteLine("Mobile Number {0} is valid", num);
            }
            else
            {
                Console.WriteLine("Mobile Number {0} is invalid", num);
            }
            return regex.IsMatch(num);
        }

        /// <summary>
        /// Password is in following pattern
        /// </summary>
        /// <param name="psw"></param>
        public bool Password(string psw)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*\W)[A-Za-z\d@$!%*?&]{8,}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(psw))
            {
                Console.WriteLine("Password {0} is valid", psw);
            }
            else
            {
                Console.WriteLine("Password {0} is invalid", psw);
            }
            return regex.IsMatch(psw);
        }

    }
}
