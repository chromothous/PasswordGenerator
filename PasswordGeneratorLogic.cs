using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordGenerator;

namespace PasswordGenerator
{
    class PasswordGeneratorLogic
    {
        // character sets available for password construction
        public string SpecialCharacters = "~`!@#$%^&*()_-=|[]{};:'.>/?";
        public string UpperCaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public string LowerCaseLetters = "abcdefghijklmnopqrstuvwxyz";
        public int[] Numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
        public string[] FourLetterWords = ["Tree", "Rock", "Wind", "Book", "Code", "Desk", "Lamp", "Note", "Void", "Fang", "Wisp", "Grim", "Husk", "Bane", "Claw", "Lurk", "Byte", "Ping", "Node", "Hash", "Port", "Data", "Boot", "Loop"];

        //Setting up bools for whether the user wants certain things included.
        public bool SCIncluded;
        public bool ULIncluded;
        public bool LLIncluded;
        public bool NIncluded;
        public bool FLWIncluded;

        // Holds target length, working length, and final password result.
        public int TrueLength;
        public int RemainingLength;
        public string NewPassword;
        public int PasswordStrength;

        //Setting up the password logic's needed parameters from what the user chooses.
        public PasswordGeneratorLogic(MainForm usedForm)
        {
            NewPassword = "";
            SCIncluded = usedForm.SpecialCharacters;
            ULIncluded = usedForm.UppercaseLetters;
            LLIncluded = usedForm.LowercaseLetters;
            NIncluded = usedForm.Numbers;
            FLWIncluded = usedForm.FourLetterWords;

            TrueLength = usedForm.PasswordLength;
            RemainingLength = usedForm.PasswordLength;
        }


        //The logic of using random values to insert into the password.
        public void PasswordGenerator()
        {
            Random rng = new Random();

            Console.WriteLine("Generating...");

            // Main loop: build password while at least 4 characters remain (to allow for four-letter word insertion)
            while (this.RemainingLength > 4)
            {
                int randomChoice = rng.Next(0, 5);
                
                if (SCIncluded == true && randomChoice == 0)
                {
                    this.NewPassword += this.SpecialCharacters[rng.Next(0, this.SpecialCharacters.Length)];
                    this.RemainingLength -= 1;
                }
                else if (ULIncluded == true && randomChoice == 1)
                {
                    this.NewPassword += this.UpperCaseLetters[rng.Next(0, this.UpperCaseLetters.Length)];
                    this.RemainingLength -= 1;
                }
                else if (LLIncluded == true && randomChoice == 2)
                {
                    this.NewPassword += this.LowerCaseLetters[rng.Next(0, this.LowerCaseLetters.Length)];
                    this.RemainingLength -= 1;
                }
                else if (NIncluded == true && randomChoice == 3)
                {
                    this.NewPassword += this.Numbers[rng.Next(0, this.Numbers.Length)];
                    this.RemainingLength -= 1;
                }
                else if (this.FLWIncluded == true && randomChoice == 4)
                {
                    this.NewPassword += this.FourLetterWords[rng.Next(0, this.FourLetterWords.Length)];
                    this.RemainingLength -= 4;
                }
                else
                {
                    continue;
                }
            }

            // Fill remaining characters using other included character sets
            while (this.RemainingLength > 0)
            {
                int randomChoice = rng.Next(0, 4);

                if (SCIncluded == false && ULIncluded == false && LLIncluded == false && NIncluded == false)
                {
                    this.RemainingLength = 0;
                    Console.WriteLine("Password length shortened because of only using four letter words.");
                }
                if (SCIncluded == true && randomChoice == 0)
                {
                    this.NewPassword += this.SpecialCharacters[rng.Next(0, this.SpecialCharacters.Length)];
                    this.RemainingLength -= 1;
                }
                else if (ULIncluded == true && randomChoice == 1)
                {
                    this.NewPassword += this.UpperCaseLetters[rng.Next(0, this.UpperCaseLetters.Length)];
                    this.RemainingLength -= 1;
                }
                else if (LLIncluded == true && randomChoice == 2)
                {
                    this.NewPassword += this.LowerCaseLetters[rng.Next(0, this.LowerCaseLetters.Length)];
                    this.RemainingLength -= 1;
                }
                else if (NIncluded == true && randomChoice == 3)
                {
                    this.NewPassword += this.Numbers[rng.Next(0, this.Numbers.Length)];
                    this.RemainingLength -= 1;
                }
                else
                {
                    continue;
                }
            }

            // Final scoring for password strength based on composition and length
            if (this.TrueLength >= 8 && this.TrueLength < 16)
            {
                this.PasswordStrength += 1;
            }
            else if (this.TrueLength >= 16 && this.TrueLength < 24)
            {
                this.PasswordStrength += 2;
            }
            else if (this.TrueLength >= 24)
            {
                this.PasswordStrength += 3;
            }
            if (this.SCIncluded == true)
            {
                this.PasswordStrength += 1;
            }
            if (this.ULIncluded == true)
            {
                this.PasswordStrength += 1;
            }
            if (this.LLIncluded == true)
            {
                this.PasswordStrength += 1;
            }
            if (this.NIncluded == true)
            {
                this.PasswordStrength += 1;
            }
            if (this.FLWIncluded == true)
            {
                this.PasswordStrength += 1;
            }
        }
    }

    
}
