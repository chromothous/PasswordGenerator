using System;
using PasswordGenerator;

namespace PasswordGenerator
{
    static class Program
    {
        
        /// The main entry point for the application.
        
        static void Main()
        {
            Console.WriteLine("Welcome to my password Generator.");

            MainForm PasswordForm = new MainForm();

            PasswordGeneratorLogic PasswordGenerator = new PasswordGeneratorLogic();

            PasswordForm.FillingForm();

            PasswordGenerator.RemainingLength = PasswordForm.PasswordLength;
            PasswordGenerator.TrueLength = PasswordForm.PasswordLength;

            PasswordGenerator.SCIncluded = PasswordForm.SpecialCharacters;
            PasswordGenerator.ULIncluded = PasswordForm.UppercaseLetters;
            PasswordGenerator.LLIncluded = PasswordForm.LowercaseLetters;
            PasswordGenerator.NIncluded = PasswordForm.Numbers;
            PasswordGenerator.FLWIncluded = PasswordForm.FourLetterWords;

            PasswordGenerator.PasswordGenerator();

            Console.WriteLine("Thanks for using my password generator.");
        }
    }
}

