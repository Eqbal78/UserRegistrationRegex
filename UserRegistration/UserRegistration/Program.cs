using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Welcome to User Registration Problem--------------------");
            ////object create
            //Registrations user = new Registrations();
            ////First Name
            //Console.WriteLine("Enter your First name : ");
            //string firstName = Console.ReadLine();
            //user.FirstName(firstName);

            ////Last Name
            //Console.WriteLine("\nEnter your Last name : ");
            //string lastName = Console.ReadLine();
            //user.LastName(lastName);

            ////Email Validation
            //Console.WriteLine("\nEnter your Email:");
            //string email = Console.ReadLine();
            //user.Email(email);

            ////Phone Number
            //Console.WriteLine("\nEnter your Mobile Number:");
            //string num = Console.ReadLine();
            //user.PhoneNumber(num);

            ////Password
            //Console.WriteLine("\nEnter your Password:");
            //string psw = Console.ReadLine();
            //user.Password(psw);

            ////Sample Email
            //user.Email("abc@yahoo.com");
            //user.Email("abc-100@yahoo.com");
            //user.Email("abc@gmail.com.com");
            //user.Email("abc.100@yahoo.com");
            //user.Email("abc111@abc.com");
            //user.Email("abc-100@abc.net");
            //user.Email("abc.100@abc.com.au");
            //user.Email("abc@1.com");
            //user.Email("abc+100@gmail.com");
            //user.Email("abc");
            //user.Email("abc@.com.my");
            //user.Email("abc123@gmail.a");
            //user.Email("abc123@.com");
            //user.Email(".abc@abc.com");
            //user.Email("abc()*@gmail.com");
            //user.Email("abc@%*.com");
            //user.Email("abc..2002@gmail.com");
            //user.Email("abc.@gmail.com");
            //user.Email("abc@abc@gmail.com");

            LambdaExpression exp = new LambdaExpression();
            exp.Validate();
        }
    }
}
