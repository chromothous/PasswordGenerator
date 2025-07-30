using System;
using PasswordGenerator;

namespace PasswordGenerator
{
    static class Program
    {
        
        // The main entry point for the application.
        // Initializes the form, gathers user input, generates the password, and displays results.
        static void Main()
        {
            Console.WriteLine("Welcome to my password Generator.");

            MainForm PasswordForm = new MainForm();

            PasswordForm.FillingForm();

            PasswordGeneratorLogic PasswordGenerator = new PasswordGeneratorLogic(PasswordForm);

            PasswordGenerator.PasswordGenerator();
            Console.WriteLine(PasswordGenerator.NewPassword);
            Console.WriteLine("Password strength is: " + PasswordGenerator.PasswordStrength + "/8");

            Console.WriteLine("Thanks for using my password generator.");
        }
    }
}

