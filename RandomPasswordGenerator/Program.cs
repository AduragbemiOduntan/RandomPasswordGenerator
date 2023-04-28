/*
 * 3. Random Password Generator: (Ayo & Adura)
Write a program that generates a random password of length 8, consisting of upper and lower case 
letters, numbers, and special characters.

Additional:
 Make the length of the password customizable: Allow the user to enter a desired password 
length, and generate a password of that length.

 Add options for different character types: Allow the user to choose which types of characters to 
include in the password (e.g. uppercase letters only, numbers and special characters only, etc.).

 Ensure that the generated password meets certain requirements: For example, you could 
require that the password contains at least one uppercase letter, one lowercase letter, one 
number, and one special character.

 Use a cryptographically secure random number generator: Instead of using a standard random 
number generator, use a cryptographically secure one to generate the random characters for 
the password. This will make the password more secure.

 Generate multiple passwords at once: Instead of generating a single password, generate a list of 
several passwords, each with different combinations of characters and lengths.
 */

do
{
    Console.WriteLine("Welocme to RPG machine, kindly input the desire option to cotinue:\n1: Customize password\n2: Generate default\n3: Close program");
    bool optionInput = byte.TryParse(Console.ReadLine(), out byte value);

    if (optionInput)
    {
        switch (value)
        {
            case 1:
                GenerateDefaultPassword();
                continue;
            //case 2:
            //    break;
            default:
                return;

        }
    }
    else 
        Console.WriteLine("Invalid option. Please input a valid option");
   
} while (true);

static void GenerateDefaultPassword()
{
    var randomObj = new Random();
    char characters = (char)randomObj.Next();
    for (int i = 0; i < 2; i++)
    {
        Console.Write((char)randomObj.Next(97, 123));
        Console.Write((char)randomObj.Next(97, 123));
        if(i == 1) 
        { 
            Console.Write((char)randomObj.Next(65, 91));
            Console.Write((char)randomObj.Next(32,40));
            break;
        }
        Console.Write((char)randomObj.Next(33, 39));
        Console.Write((char)randomObj.Next(41, 48));
    }
    Console.WriteLine();
}

