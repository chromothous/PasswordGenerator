////Password Generator////

A console-based password generator written in C#, designed to give users flexible control over their password composition while maintaining straightforward and understandable logic.

////Overview////

This project allows users to generate strong, customizable passwords by selecting which types of characters and elements to include. The password can contain: Special characters (e.g., ~!@#$%^&*), Uppercase letters (A-Z), Lowercase letters (a-z), Numbers (0-9), and Four-letter words (from a predefined list)

The generator dynamically builds a password based on the user’s choices and desired length, balancing complexity and readability.

////Features////

User-driven input: The program prompts users to specify password length and which character types to include.

Form validation: Inputs are validated to ensure they meet expected formats and constraints.

Adaptive logic: The password is constructed randomly but respects user preferences, including the choice to incorporate meaningful four-letter words.

Password strength estimation: Based on length and included character types, the program calculates a simple strength score.

////How to Use////

Run the program.

When prompted, enter the desired password length (between 8 and 32 characters).

Respond true or false to whether you want to include: Special characters, Uppercase letters, Lowercase letters, Numbers, and Four-letter words

The program will generate and display a password based on your selections.

////Code Structure////

MainForm class: Handles user input and validates choices.

PasswordGeneratorLogic class: Contains the core logic for constructing the password based on user settings.

Program entry point at program.cs: Creates instances of the above classes and coordinates the flow.

////Notes////

The inclusion of four-letter words reduces the remaining length by four characters each time one is added, so the password length may adjust accordingly.

Password strength is a simple heuristic based on length and variety of character types selected.
