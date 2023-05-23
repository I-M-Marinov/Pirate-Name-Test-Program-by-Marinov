using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("♠♠♠  Welcome to my console test program  ♠♠♠");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello there, {name} !!!");
            Console.WriteLine("---------------------------------------------------------");

            while (true)
            {
                Console.WriteLine("How old are you ?");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------------------------------");



                if (age < 18 && age > 0)
                {
                    Console.WriteLine("I am sorry!\n");
                    Console.WriteLine("----You----\n");
                    Console.WriteLine("---cannot--\n");
                    Console.WriteLine("--continue--\n");
                    Console.WriteLine("---further--\n");
                    Console.WriteLine("PROGRAM TERMINATED\n");
                    Environment.Exit(50);
                }
                else if (age >= 18 && age < 100)
                {
                    Console.WriteLine("Looks like you are old enough to continue                ");
                    Console.WriteLine("---------------------------------------------------------");
                    break;
                }
                else if (age <= 0)
                {
                    Console.WriteLine("I think you made a mistake, let's try this again ?");
                    Console.WriteLine("---------------------------------------------------------");
                }
                else if (age > 100)
                {
                    Console.WriteLine("I think you made a mistake, let's try this again ?");
                    Console.WriteLine("---------------------------------------------------------");
                }

            }
            while (true)
            {
                Console.WriteLine($"George has 10 bottles of vodka, he gives half of it away to his friend {name}.");
                Console.WriteLine($"How many does George and {name} each have ?");
                double numberOfBottles = double.Parse(Console.ReadLine());
                if (numberOfBottles != 5)
                {
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine(" I think you had too much to drink yourself. C'mon this is basic math. Try this again..");
                    Console.WriteLine("---------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine($"Besides the headache on the next morning, they have {numberOfBottles} bottles each. Correct !");
                    Console.WriteLine("---------------------------------------------------------");
                    break;
                }
            }
            while (true)
            {
                Console.WriteLine("What is your favourite color ?");
                string colour = Console.ReadLine();

                if (colour == "black")
                {
                    Console.WriteLine("Is that you Batman ? Maybe not, let's continue ...");
                    Console.WriteLine("---------------------------------------------------------");
                    break;
                }
                else if (colour == "yellow")
                {
                    Console.WriteLine($"{name}, do you like bananas ? Nevermind, let's continue..");
                    Console.WriteLine("---------------------------------------------------------");
                    break;
                }
                else if (colour == "red")
                {
                    Console.WriteLine("Roses are red, violet's are blue ... and we need to continue..");
                    Console.WriteLine("---------------------------------------------------------");
                    break;
                }
                else if (colour == "blue")
                {
                    Console.WriteLine("I hope you are not feeling blue as well ? I am sure you are alright, let's continue..");
                    Console.WriteLine("---------------------------------------------------------");
                    break;
                }
                else if (colour == "purple")
                {
                    Console.WriteLine("You must also be a fan of Deep Purple, right? Nevermind, let's continue..");
                    Console.WriteLine("---------------------------------------------------------");
                    break;
                }
                else if (colour == "white")
                {
                    Console.WriteLine("Too early to surrender! Let's continue..");
                    Console.WriteLine("---------------------------------------------------------");
                    break;
                }
                else if (colour == "orange")
                {
                    Console.WriteLine("You must be crazy about tangerines ? Let's continue..");
                    Console.WriteLine("---------------------------------------------------------");
                    break;
                }
                else if (colour == "green")
                {
                    Console.WriteLine("Green like the HULK or green like grass ? Maybe both..");
                    Console.WriteLine("---------------------------------------------------------");
                    break;
                }
                else if (colour != "black" && colour != "yellow" && colour != "red" && colour != "blue" && colour != "purple" && colour != "white" && colour != "green")
                {
                    Console.WriteLine("Are you sure you are listing a colour? let's try again ---->");
                    Console.WriteLine("---------------------------------------------------------");
                }

            }

            Console.WriteLine($"Hey {name}, can you tell me where are you from?");
            string cityFrom = Console.ReadLine();
            Console.WriteLine("I'll be sure to remember that.");
            Console.WriteLine("---------------------------------------------------------");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            while (true)
            {
                Console.WriteLine($"Hey, {name} do you want to find out what is your pirate name?");
                string answer1 = Console.ReadLine();
                Console.WriteLine("---------------------------------------------------------");


                if (answer1 == "yes" || answer1 == "sure" || answer1 == "ok")
                {
                    Console.WriteLine("Ok, I have a few questions for you then.");
                    Console.WriteLine("---------------------------------------------------------");
                    break;
                }
                else if (answer1 == "no" || answer1 == "nope")
                {
                    Console.WriteLine("Too bad it is pretty fun, but maybe next time..");
                    Console.WriteLine("Goodbye...PROGRAM TERMINATED!!!\n\n\n\n\n");
                    Console.WriteLine("---------------------------------------------------------");
                    Environment.Exit(0);
                }
                else if (answer1 != "yes" || answer1 != "sure" || answer1 != "ok" || answer1 != "no" || answer1 != "nope")
                {
                    Console.WriteLine("You did not answer the question..Let's try this again ?");
                    Console.WriteLine("---------------------------------------------------------");

                }
                else
                {
                    Console.WriteLine("Let's try again ? It is a simple question is it not ? ");
                }
            }

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("What is the first letter of your first name ?");
            string firstNameLetter = Console.ReadLine();

            switch (firstNameLetter)
            {
                case "a":
                    firstNameLetter = "Ol`";
                    break;
                case "b":
                    firstNameLetter = "Stinky";
                    break;
                case "c":
                    firstNameLetter = "Creeps";
                    break;
                case "d":
                    firstNameLetter = "One Eye";
                    break;
                case "e":
                    firstNameLetter = "Captain";
                    break;
                case "f":
                    firstNameLetter = "Fishy";
                    break;
                case "g":
                    firstNameLetter = "Rogue";
                    break;
                case "h":
                    firstNameLetter = "Sharkbait";
                    break;
                case "i":
                    firstNameLetter = "Red";
                    break;
                case "j":
                    firstNameLetter = "Sticky";
                    break;
                case "k":
                    firstNameLetter = "Ghost";
                    break;
                case "l":
                    firstNameLetter = "Whale";
                    break;
                case "m":
                    firstNameLetter = "Flying";
                    break;
                case "n":
                    firstNameLetter = "Cutlass";
                    break;
                case "o":
                    firstNameLetter = "King";
                    break;
                case "p":
                    firstNameLetter = "Ironhook";
                    break;
                case "q":
                    firstNameLetter = "Mad";
                    break;
                case "r":
                    firstNameLetter = "Ruthless";
                    break;
                case "s":
                    firstNameLetter = "Jean";
                    break;
                case "t":
                    firstNameLetter = "Gunpowder";
                    break;
                case "u":
                    firstNameLetter = "Sassy";
                    break;
                case "v":
                    firstNameLetter = "Walker";
                    break;
                case "w":
                    firstNameLetter = "Salt";
                    break;
                case "x":
                    firstNameLetter = "Cesar";
                    break;
                case "y":
                    firstNameLetter = "Long John";
                    break;
                case "z":
                    firstNameLetter = "Sidekick";
                    break;
                default:
                    Console.WriteLine("Please write only small letters. Try again:");
                    break;

            }

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("What is the last letter of your first name ?");
            string lastLetterOfFirstName = Console.ReadLine();

                switch (lastLetterOfFirstName)
                {
                    case "a":
                        lastLetterOfFirstName = "Lagoon";
                        break;
                    case "b":
                        lastLetterOfFirstName = "Barnacle";
                        break;
                    case "c":
                        lastLetterOfFirstName = "Creepy";
                        break;
                    case "d":
                        lastLetterOfFirstName = "Plank";
                        break;
                    case "e":
                        lastLetterOfFirstName = "Slappy";
                        break;
                    case "f":
                        lastLetterOfFirstName = "Beard";
                        break;
                    case "g":
                        lastLetterOfFirstName = "Hook";
                        break;
                    case "h":
                        lastLetterOfFirstName = "Crabbe";
                        break;
                    case "i":
                        lastLetterOfFirstName = "Blubber";
                        break;
                    case "j":
                        lastLetterOfFirstName = "Broom";
                        break;
                    case "k":
                        lastLetterOfFirstName = "Treasure";
                        break;
                    case "l":
                        lastLetterOfFirstName = "One-Ear";
                        break;
                    case "m":
                        lastLetterOfFirstName = "Claw";
                        break;
                    case "n":
                        lastLetterOfFirstName = "Parrot";
                        break;
                    case "o":
                        lastLetterOfFirstName = "Flag";
                        break;
                    case "p":
                        lastLetterOfFirstName = "Stubbs";
                        break;
                    case "q":
                        lastLetterOfFirstName = "Gutt";
                        break;
                    case "r":
                        lastLetterOfFirstName = "Von";
                        break;
                    case "s":
                        lastLetterOfFirstName = "Swamp";
                        break;
                    case "t":
                        lastLetterOfFirstName = "Black Jack";
                        break;
                    case "u":
                        lastLetterOfFirstName = "O'";
                        break;
                    case "v":
                        lastLetterOfFirstName = "Wild Winds";
                        break;
                    case "w":
                        lastLetterOfFirstName = "Squint";
                        break;
                    case "x":
                        lastLetterOfFirstName = "Bully";
                        break;
                    case "y":
                        lastLetterOfFirstName = "Nautical";
                        break;
                    case "z":
                        lastLetterOfFirstName = "Prince";
                        break;
                }

                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("What is the first letter of your surname?");
                string firstLetterOfSurname = Console.ReadLine();

                switch (firstLetterOfSurname)
                {
                    case "a":
                        firstLetterOfSurname = "Sea";
                        break;
                    case "b":
                        firstLetterOfSurname = "Joe";
                        break;
                    case "c":
                        firstLetterOfSurname = "Pants";
                        break;
                    case "d":
                        firstLetterOfSurname = "Swashbuckler";
                        break;
                    case "e":
                        firstLetterOfSurname = "McGee";
                        break;
                    case "f":
                        firstLetterOfSurname = "Legs";
                        break;
                    case "g":
                        firstLetterOfSurname = "Smuggler";
                        break;
                    case "h":
                        firstLetterOfSurname = "Fishhawk";
                        break;
                    case "i":
                        firstLetterOfSurname = "Jack";
                        break;
                    case "j":
                        firstLetterOfSurname = "Moonscar";
                        break;
                    case "k":
                        firstLetterOfSurname = "Feathersword";
                        break;
                    case "l":
                        firstLetterOfSurname = "Rat Breath";
                        break;
                    case "m":
                        firstLetterOfSurname = "Skurvy";
                        break;
                    case "n":
                        firstLetterOfSurname = "Sea Rat";
                        break;
                    case "o":
                        firstLetterOfSurname = "Silver";
                        break;
                    case "p":
                        firstLetterOfSurname = "Slag";
                        break;
                    case "q":
                        firstLetterOfSurname = "Turner";
                        break;
                    case "r":
                        firstLetterOfSurname = "of the Sea";
                        break;
                    case "s":
                        firstLetterOfSurname = "Jambe de Bois";
                        break;
                    case "t":
                        firstLetterOfSurname = "Dancer";
                        break;
                    case "u":
                        firstLetterOfSurname = "Dark Water";
                        break;
                    case "v":
                        firstLetterOfSurname = "Bart";
                        break;
                    case "w":
                        firstLetterOfSurname = "Steve";
                        break;
                    case "x":
                        firstLetterOfSurname = "Sparrow";
                        break;
                    case "y":
                        firstLetterOfSurname = "Monkey";
                        break;
                    case "z":
                        firstLetterOfSurname = "Cove";
                        break;
                }
       
            Console.WriteLine($"You name is Captain Jack Sparrow! Not really, you name is actually:\n\n");
            Console.WriteLine("*********************************************************");
            Console.WriteLine($"                {firstNameLetter} {lastLetterOfFirstName} {firstLetterOfSurname} arrrrrrr !             ");
            Console.WriteLine("*********************************************************");

            Console.WriteLine("Thank you for checking out my test program :) Have a nice day ! ");
            Environment.Exit(50);
        }
    }
    }
