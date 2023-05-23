using System;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine($"Hey, Ivan do you want to play a game?");
            string answer1 = Console.ReadLine();
            Console.WriteLine("---------------------------------------------------------");
                              
                
                if (answer1 == "yes" || answer1 == "sure" || answer1 == "ok")
                    {
                        Console.WriteLine("Ok, here we go then");
                        Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine($"Let's find out what is your pirate name {name}?");
                    }
                    else if (answer1 == "no" || answer1 == "nope")
                    {
                        Console.WriteLine("Too bad it is pretty fun, but maybe next time..");
                        Console.WriteLine("---------------------------------------------------------");
                    break;
                     }
                    else if (answer1 != "yes" || answer1 != "sure" || answer1 != "ok" || answer1 != "no" || answer1 != "nope")
                    {
                        Console.WriteLine("You did not asnwer the question..Let's try this again ?");
                        Console.WriteLine("---------------------------------------------------------");
                        
                    }
             }
        }
    }
}




