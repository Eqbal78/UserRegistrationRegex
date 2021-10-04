using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{ 
    public class LambdaExpression
    {
        /// <summary>
        /// User validation
        /// </summary>
        public void Validate()
        {
            //create a string array for Regex Pattern
            string[] RegexPattern = new string[6];

            RegexPattern[0] = "^[A-Z]{1}[a-z]{3,}$";

            RegexPattern[1] = "^[A-Z]{1}[a-z]{3,}$";

            RegexPattern[2] = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";

            RegexPattern[3] = @"^[1-9]{2}" + " " + "[1-9]{1}[0-9]{9}$";

            RegexPattern[4] = @"^(?=.*[A-Z])(?=.*\d)(?=.*\W)[A-Za-z\d@$!%*?&]{8,}$";

            RegexPattern[5] = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";

            //create a string array for user input
            string[] UserInput = new string[6];

            Console.Write("Enter First Name :");
            UserInput[0] = Console.ReadLine();


            Console.Write("Enter Last Name :");
            UserInput[1] = Console.ReadLine();


            Console.Write("Enter  Email Id : ");
            UserInput[2] = Console.ReadLine();


            Console.Write("Enter the Phone Number : ");
            UserInput[3] = Console.ReadLine();


            Console.Write("Enter Password : ");
            UserInput[4] = Console.ReadLine();

            Console.Write("Enter Sample Email Id : ");
            UserInput[5] = Console.ReadLine();

            Console.WriteLine("............................");

            for (int i = 0; i < 6; i++)
            {
                //Delegate Fuctions to use the Lambda Expession
                Func<string, bool> nameValidater = UserInput => Regex.IsMatch(UserInput, RegexPattern[i]);
                //by using Delegate it return bool value
                bool result = nameValidater(UserInput[i]);
                Console.WriteLine(($"{i + 1} {UserInput[i]} : {result}"));

            }
        }
    }
}
