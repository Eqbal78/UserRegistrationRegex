using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Welcome to User Registration Problem--------------------");
            //object create
            Registrations user = new Registrations();
            //First Name
            Console.WriteLine("Enter your first name : ");
            string firstName = Console.ReadLine();
            user.FirstName(firstName);

            //Last Name
            Console.WriteLine("\nEnter your last name : ");
            string lastName = Console.ReadLine();
            user.LastName(lastName);

            //Email Validation
            Console.WriteLine("\nEnter your Email:");
            string email = Console.ReadLine();
            user.Email(email);

            //Phone Number
            Console.WriteLine("\nEnter your Mobile Number:");
            string num = Console.ReadLine();
            user.PhoneNumber(num);
        }
    }
}
