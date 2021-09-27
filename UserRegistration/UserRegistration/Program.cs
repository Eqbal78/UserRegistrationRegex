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
            Console.WriteLine("Enter your first name : ");
            string firstName = Console.ReadLine();
            user.Check(firstName);
        }
    }
}
