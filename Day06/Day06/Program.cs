using System;
using System.Collections.Generic;

namespace Day06
{

    enum Weapon
    {
        Sword, Axe, Spear, Mace
    }
    internal class Program
    {
        static void Main(string[] args)
        {


            /*   
                ╔══════════════════════════╗ 
                ║ Dictionary<TKey, TValue> ║
                ╚══════════════════════════╝ 

                [  Removing a key and its value from a Dictionary  ]

                Remove(key) -- returns true/false if the key was found

                You do NOT need to check if the key is in dictionary. Check the returned bool.
               
            */
            Dictionary<Weapon, int> backpack = new Dictionary<Weapon, int>()
            {
                {Weapon.Sword, 5 }
            };
            backpack.Add(Weapon.Axe, 2);
            backpack[Weapon.Spear] = 1;


            bool wasFound = backpack.Remove(Weapon.Mace);
            if (!wasFound) Console.WriteLine($"{Weapon.Mace} was NOT found.");

            /*
                CHALLENGE 1:

                            print the students and grades below
                            ask for the name of the student to drop from the grades dictionary
                            call Remove to remove the student
                            print message indicating what happened
                                error message if not found
                            else print the dictionary again and print that the student was removed

             
            */
            Dictionary<string, double> grades = GetGrades();
            PrintGrades(grades);
            
        }

        private static Dictionary<string, double> GetGrades()
        {
            Random randy = new Random();
            Dictionary<string, double> grades = new()
            {
                {"Shaun", randy.NextDouble()*100  },
                {"Levi", randy.NextDouble()*100  },
                {"Jerry", randy.NextDouble()*100  },
                {"Zachary", randy.NextDouble()*100  }
            };
            grades.Add("Kliment", randy.NextDouble() * 100);
            grades.Add("Dean", randy.NextDouble() * 100);
            grades.Add("James", randy.NextDouble() * 100);
            grades.Add("Ty", randy.NextDouble() * 100);
            grades.Add("Christopher", randy.NextDouble() * 100);
            grades.Add("Thomas", randy.NextDouble() * 100);

            grades["Johncarlos"] = randy.NextDouble() * 100;
            grades["Bjorn"] = randy.NextDouble() * 100;
            grades["Kaden"] = randy.NextDouble() * 100;
            grades["Austin"] = randy.NextDouble() * 100;
            grades["Logan"] = randy.NextDouble() * 100;
            grades["Judah"] = randy.NextDouble() * 100;
            grades["Cole"] = randy.NextDouble() * 100;
            grades["Robert"] = randy.NextDouble() * 100;
            grades["Gabriel"] = randy.NextDouble() * 100;
            grades["Chelsea"] = randy.NextDouble() * 100;
            grades["Kevin"] = randy.NextDouble() * 100;
            grades["Camden"] = randy.NextDouble() * 100;
            grades["Adam"] = randy.NextDouble() * 100;
            grades["Damian"] = randy.NextDouble() * 100;
            grades["Otto"] = randy.NextDouble() * 100;
            grades["Tyrone"] = randy.NextDouble() * 100;
            grades["Darien"] = randy.NextDouble() * 100;

            return grades;
        }

        private static void PrintGrades(Dictionary<string, double> grades)
        {
            Console.WriteLine("----------PG2-----------");
            foreach (KeyValuePair<string, double> studentgrade in grades)
            {
                string student = studentgrade.Key;
                double grade = studentgrade.Value;
                SetGradeColor(grade);
                Console.Write($"{grade,7:N2} ");
                Console.ResetColor();

                Console.WriteLine($"{student}");
            }
        }

        private static void SetGradeColor(double grade)
        {
            Console.ForegroundColor = (grade < 59.5) ? ConsoleColor.Red :
                                (grade < 69.5) ? ConsoleColor.DarkYellow :
                                (grade < 79.5) ? ConsoleColor.Yellow :
                                (grade < 89.5) ? ConsoleColor.Blue :
                                ConsoleColor.Green;
        }
    }
}
