using System;
using System.Collections.Generic;

namespace Choose_Your_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Rogue rogue = new Rogue();

            Console.WriteLine("Welcome to Rogue Simulator 2020!");
            Console.WriteLine("It's a pretty awful year, live a little with a mildly amusing console app.\n");

            rogue.Initialization();

            bool playGame = true;
            while (playGame)
            {
                rogue.MenuDisplay();

                string gameMenuOption = Console.ReadLine();
                switch (gameMenuOption)
                {
                    case "1":
                        string specialization = Console.ReadLine();
                        rogue.SetSpecialization(specialization);
                        Console.WriteLine($"Your Specialization is now {rogue.GetSpecialization()}.");
                        rogue.Continue();
                        break;
                    case "2":
                        rogue.DisplayStats();
                        rogue.Continue();
                        break;
                    case "3":
                        rogue.Practice();
                        Console.WriteLine("\nYou expertly practice your devilish skills. [Talent Stat Awarded]\n");
                        rogue.Continue();
                        break;
                    case "4":
                        rogue.Rest();
                        Console.WriteLine("\nNaturally, you locate a bar and begin to annoy its patrons. [Energy Stat Awarded]\n");
                        rogue.Continue();
                        break;
                    case "5":
                        rogue.Tick();
                        rogue.LevelUp();
                        Console.WriteLine($"\nSome mild poking with a little added {rogue.GetSpecialization()}, a bribe here, and some charm there... Job's done.\n");
                        rogue.StatCheck25();
                        rogue.StatCheck0();
                        rogue.Continue();
                        break;
                    case "6":
                        Console.WriteLine("\nThanks for living a little on the dark side.\n");
                        playGame = false;
                        rogue.Continue();
                        break;
                    default:
                        Console.WriteLine("\nWhile there's no rules for Rogues, you should give a valid entry.\n");
                        break;
                }
            }
        }
    }
}
