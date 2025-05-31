I’d like to create a C# project that generates weak to strong passwords, whatever the User wishes to have, and the password would have a good amount of entropy. There would be a UI for… 

Selecting the Length they want the password to be (8 - 32).

Selecting whether they would like special characters or not.

Selecting whether they would like uppercase letters or not.

Selecting whether they would like lowercase letters or not.

Selecting how many four-letter words they would like in the password (This would 
handle cases based on the length they submit.)

Selecting whether they would like numbers in their password.

After this, the password generator would generate a password and scale from 1 to 8, measuring the password's strength. 3 points would be based on the length, 4 points would be based on each type of character being selected, and 1 additional point if the four-letter words are included. This would also stop the user if they choose not to select anything at all.

## Out of bounds, Things that won’t be part of this app:

Saving and encrypting passwords for user. (This isn’t a limitation, I just believe this is dangerous to do.)

Live password strength feedback as the user types.

Login/signup systems.


Hashing passwords for users.


Comparing password input against stored credentials.

Meet compliance standards like NIST or OWASP.


Integrate security libraries.

The app will likely be in English only.

##File structure:

##For form creation
  MainForm.cs
##For Password Generator Logic
  PasswordGeneratorLogic.cs
## Main program
  Program.cs


