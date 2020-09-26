using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Choose_Your_Class
{
    public class Rogue
    {
        public string Name { get; set; }
        public string Specialization { get; set; }
        public string Title { get; set; }
        public int Energy { get; set; }
        public int Talent { get; set; }
        public int Level { get; set; }
        public int Gold { get; set; }
        public Rogue()
        {
            Energy = 100;
            Talent = 50;
            Level = 1;
            Gold = 0;
        }
        
        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetTitle()
        {
            if (Level == 1)
            {
                return null;
            }
            else if (Level == 2)
            {
                Title = " Stranger";
                return Title;
            }
            else if (Level == 3)
            {
                Title = " Recruit";
                return Title;
            }
            else if (Level == 4)
            {
                Title = " Thief";
                return Title;
            }
            else if (Level == 5)
            {
                Title = " Monarch's Bane";
                return Title;
            }
            else if (Level == 6)
            {
                Title = " Shadow";
                return Title;
            }
            else
            {
                Title = " Guild Leader";
                return Title;
            }
        }

        public void SetSpecialization(string specialization)
        {
            Specialization = specialization;
        }

        public string GetSpecialization()
        {
            return Specialization;
        }

        public int GetGold()
        {
            return Gold;
        }
        public int GetEnergy()
        {
            return Energy;
        }
        public int GetTalent()
        {
            return Talent;
        }
        public int GetLevel()
        {
            return Level;
        }

        public void Practice()
        {
            Talent += 10;
        }

        public void Rest()
        {
            Energy += 10;
        }

        public void LevelUp()
        {
            Level += 1;
        }

        public void Tick()
        {
            Talent -= 6;
            Energy -= 4;
            Gold += 100;
        }
        public void Continue()
        {
            Console.WriteLine("Press any key to continue.\n");
            Console.ReadKey();
        }

        public void DisplayStats()
        {
            Console.WriteLine($"\n{GetTitle()} {GetName()}:\n");
            Console.WriteLine($"Specialization: '{GetSpecialization()}'.");
            Console.WriteLine($"Level: {GetLevel()}.");
            Console.WriteLine($"Energy: {GetEnergy()}.");
            Console.WriteLine($"Talent: {GetTalent()}.");
            Console.WriteLine($"Gold: {GetGold()}.\n");
        }

        public void StatCheck25()
        {
            if (Energy <= 25 )
            {
                Console.WriteLine("\nDon't let your enemies catch up to you! Energy is low! You should Rest soon.\n");
            }
            else if (Talent <= 25)
            {
                Console.WriteLine("\nMaintaining your abilities requires commitment. Talent is Low! You should Practice soon.\n");
            }
        }
        public void StatCheck0()
        {
            if (Energy <= 0)
            {
                Console.WriteLine("\nYou let your enemies get the better of you. Energy Depleted. You're done here.\n");
                Continue();
                System.Environment.Exit(0);
            }
            else if (Talent <= 0)
            {
                Console.WriteLine("\nYou fell into complacency. Talent Depleted. You let your skills fade away.\n");
                Continue();
                System.Environment.Exit(0);
            }
        }
        public void MenuDisplay()
        {
            Console.WriteLine($"\nWhat's the next mission,{GetTitle()} {Name}?\n");
            Console.WriteLine($"1: Change Specialization. Currently '{GetSpecialization()}'.");
            Console.WriteLine("2: Display Stats.");
            Console.WriteLine("3: Practice. [Action. Gives Talent]");
            Console.WriteLine("4: Rest. [Action. Gives Energy]");
            Console.WriteLine("5: Complete a Mission. [Action. Depletes Stats, Gives Rewards]");
            Console.WriteLine("6: Quit.\n");
        }
        public void Initialization()
        {
            Console.WriteLine("Please start by naming your Rogue.\n");
            SetName(Console.ReadLine());
            GetName();
            Console.WriteLine($"Your Rogue's name is now {Name}.\n");
            Console.WriteLine("Please choose your Specialization. This will be your 'flair' during a mission.\n");
            SetSpecialization(Console.ReadLine());
            GetSpecialization();
            Console.WriteLine($"\n{Name}'s Specialization is now '{Specialization}'.\n");
            Console.WriteLine("Your objective is to complete missions as much as possible, while skillfully");
            Console.WriteLine("maintaining your stats. Missions give rewards but reduces your stats.");
            Console.WriteLine("The game is over if your Energy or Talent falls below 0!");
            Console.WriteLine("Use the action menu options to replenish your stats!\n");
            Console.WriteLine("BONUS: Completing missions gives Gold and Levels, that unlock hidden titles!\n");
            Continue();
        }
    }
}
