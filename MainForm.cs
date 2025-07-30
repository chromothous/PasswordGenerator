using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordGenerator;

namespace PasswordGenerator
{
    // Handles user input for password preferences and tracks form validation state.
    class MainForm
    {
        public int PasswordLength;
        public bool PasswordLengthChosen;

        public bool SpecialCharacters;
        public bool ValidSCInput;

        public bool UppercaseLetters;
        public bool ValidULInput;

        public bool LowercaseLetters;
        public bool ValidLLInput;

        public bool Numbers;
        public bool ValidNInput;

        public bool FourLetterWords;
        public bool ValidFLWInput;

        public bool FormFilled;
        public MainForm()
        {
            FormFilled = false;
            PasswordLength = 0;
            PasswordLengthChosen = false;
            ValidSCInput = false;
            ValidULInput = false;
            ValidLLInput = false;
            ValidNInput = false;
            ValidFLWInput = false;
        }

        // Collects user preferences for password generation.
        public void FillingForm()
        {
            while (this.FormFilled == false)
            {
                this.PasswordLength = this.ChoosePasswordLength();
                this.SpecialCharacters = this.ChooseSpecialCharacters();
                this.UppercaseLetters = this.ChooseUppercaseLetters();
                this.LowercaseLetters = this.ChooseLowercaseLetters();
                this.Numbers = this.ChooseNumbers();
                this.FourLetterWords = this.ChooseFourLetterWords();
                this.FormFilled = true;
            }
        }

        public int ChoosePasswordLength()
        {
            while (this.PasswordLengthChosen == false || this.PasswordLength < 8 || this.PasswordLength > 32)
            {
                Console.WriteLine("Please enter in a number from 8 - 32. This will be the length of the password generated.");

                this.PasswordLengthChosen = int.TryParse(Console.ReadLine(), out this.PasswordLength);
            }
            return this.PasswordLength;
        }

        public bool ChooseSpecialCharacters()
        {
            while (this.ValidSCInput == false)
            {
                Console.WriteLine("Would you like special characters in the password?(true/false)");

                this.ValidSCInput = bool.TryParse(Console.ReadLine(), out this.SpecialCharacters);
            }
            return this.SpecialCharacters;
        }

        public bool ChooseUppercaseLetters()
        {
            while (this.ValidULInput == false)
            {
                Console.WriteLine("Would you like to have uppercase letters in the password?(true/false)");

                this.ValidULInput = bool.TryParse(Console.ReadLine(), out this.UppercaseLetters);
            }
            return this.UppercaseLetters;
        }

        public bool ChooseLowercaseLetters()
        {
            while (this.ValidLLInput == false)
            {
                Console.WriteLine("Would you like to have lowercase letters in the password?(true/false)");

                this.ValidLLInput = bool.TryParse(Console.ReadLine(), out this.LowercaseLetters);
            }
            return this.LowercaseLetters;
        }

        public bool ChooseNumbers()
        {
            while (this.ValidNInput == false)
            {
                Console.WriteLine("Would you like to have numbers in the password?(true/false)");

                this.ValidNInput = bool.TryParse(Console.ReadLine(), out this.Numbers);
            }
            return this.Numbers;
        }

        public bool ChooseFourLetterWords()
        {
            while (this.ValidFLWInput == false)
            {
                Console.WriteLine("Would you like to have four letter words in your password?(true/false)");

                this.ValidFLWInput = bool.TryParse(Console.ReadLine(), out this.FourLetterWords);
            }
            return this.FourLetterWords;
        }
    }
}
