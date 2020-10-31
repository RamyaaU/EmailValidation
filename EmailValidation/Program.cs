using System;

namespace EmailValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Email Validation!");
            EmailValidation validation = new EmailValidation();
            Console.WriteLine("Enter you email");
            string email = Console.ReadLine();
            bool valid = validation.validateEmail(email);
            Console.WriteLine(valid);
        }
    }
}
