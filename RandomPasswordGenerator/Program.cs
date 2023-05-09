using System;
using System.Security.Cryptography;
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

//Main Program
while (true)
{
    Console.WriteLine("Welocme to RPG machine, kindly input the desire option to cotinue:\n1: Customize password\n2: Generate default\n3: Close program");
    bool optionInput = byte.TryParse(Console.ReadLine(), out byte value);

    if (optionInput)
    {
        switch (value)
        {
            case 1:
                CustomizePW();
                Console.WriteLine();
                continue;
            case 2:
                GenerateDefaultPassword();
                Console.WriteLine();
                continue;
            case 3:
                break;

        }
        Environment.Exit(0);
    }
    else
        Console.WriteLine("Invalid option. Please input a valid option");
    continue;
}

//Methods
static void GenerateDefaultPassword()
{
    var randomObj = new Random();
    char characters = (char)randomObj.Next();
    for (int i = 0; i < 2; i++)
    {
        Console.Write((char)randomObj.Next(97, 123));
        Console.Write((char)randomObj.Next(97, 123));
        if (i == 1)
        {
            Console.Write((char)randomObj.Next(65, 91));
            Console.Write((char)randomObj.Next(48, 58));
            break;
        }
        Console.Write((char)randomObj.Next(33, 39));
        Console.Write((char)randomObj.Next(41, 48));
    }
    Console.WriteLine();
}


void CustomizePW()
{
    Console.WriteLine("Specify password length\nA minimum legth of 8 characters");
    bool pwLength = byte.TryParse(Console.ReadLine(), out byte value1);
    if (pwLength)
    {
        if (value1 >= 8)
        {
            Console.WriteLine("Pick an option for your password combination");
            Console.WriteLine("1. Only uppercase & numbers\n2. Only numbers and special characters\n3. Only lower case and numbers");
            bool optionPick = byte.TryParse(Console.ReadLine(), out byte value);

            for (int i = 0; i < value1; i++)
            {
                if (optionPick)
                {
                    Random random1 = new Random();
                    switch (value)
                    {
                        case 1:
                            Console.Write((char)random1.Next(58, 97));
                            break;
                        case 2:
                            Console.Write((char)random1.Next(33, 65));
                            break;
                        case 3:
                            Console.Write((char)random1.Next(48, 58));
                            break;
                        default:
                            break;
                    }
                }
                else { Console.WriteLine("Invalid input, try again..."); }
            }
        }
    }
    else { Console.WriteLine("Invalid input or character length, give the required input"); }
}

//Cryptography
//static string DefaultPW(int count = 8)
//{
//    return Convert.ToBase64String(RandomNumberGenerator.GetBytes(count));
//}

//static string CreateSecureRandomPW(int count = 64)
//{
//    Random ran = new Random();
//    char chars = (char)ran.Next(10);
//    return Convert.ToBase64String(RandomNumberGenerator.GetBytes(count));
//}
//string secureRandomString = CreateSecureRandomPW();
//Console.WriteLine(secureRandomString);

//RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
//byte[] randomNumber = new byte[4];
//rng.GetBytes(randomNumber);
//int randomInt = BitConverter.ToInt32(randomNumber, 0);
//Console.WriteLine(randomInt);
