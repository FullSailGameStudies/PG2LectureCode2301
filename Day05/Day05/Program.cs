using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Day04
{
    internal class Program
    {
        enum Weapon
        {
            Sword, Axe, Spear, Mace
        }
        static void Main(string[] args)
        {
            /*
                ╔═════════╗ 
                ║Searching║
                ╚═════════╝ 
             
                There are 2 ways to search a list: linear search or binary search
             
                CHALLENGE 1:

                    Convert Linear Search algorithm into a method. 
                        The method should take 2 parameters: list of ints to search, int to search for.
                        The method should return -1 if NOT found or the index if found.
                     
                    The algorithm:
                        1) start at the beginning of the list
                        2) compare each item in the list to the search item
                        3) if found, return the index
                        4) if reach the end of the list, return -1 which means not found
                    
            */



            /*   
                ╔══════════════════════════╗ 
                ║ Dictionary<TKey, TValue> ║
                ╚══════════════════════════╝ 
                
                [  Creating a Dictionary  ]
                
                Dictionary<TKey, TValue>  - the TKey is a placeholder for the type of the keys. TValue is a placeholder for the type of the values.
                
                When you want to create a Dictionary variable, replace TKey with whatever type of data you want to use for the keys and
                replace TValue with the type you want to use for the values.
            */
           
            Dictionary<Weapon, int> backpack = new Dictionary<Weapon, int>();//will store the counts of each kind of weapon
            Dictionary<string, int> menu = new Dictionary<string, int>();

            /*
                CHALLENGE 2:

                    Create a Dictionary that stores names (string) and grades (double). Call the variable grades.
             
            */
            Dictionary<string, double> grades = new();




            /*  
                ╔══════════════════════════╗ 
                ║ Dictionary<TKey, TValue> ║
                ╚══════════════════════════╝ 

                [  Adding items to a Dictionary  ]

                There are 3 ways to add items to a Dictionaruy:
                1) on the initializer. 
                2) using the Add method. 
                3) using [key] = value

                Keys MUST be unique

            */
            List<string> menuItems = new List<string>() { "Apple Pie", "Pecan Pie" };
            menuItems.Add("Chocolate Pie");
            menu = new Dictionary<string, int>()
            {
                //(Key, Value)
                { "Lemon Pie", 1 },
                { "Blueberry Pie", 2 }
            };
            menu.Add("Cherry Pie", 2);
            try
            {
                menu.Add("Cherry Pie", 2);//throws an exception. key is already there.
            }
            catch (Exception)
            {
                Console.WriteLine("That was already on the menu, STEVE!");
            }
            menu["Pumpkin Pie"] = 4;
            menu["Pumpkin Pie"] = 5;//overwrites the value


            backpack = new Dictionary<Weapon, int>()
            {
                {Weapon.Sword, 5 }
            };
            backpack.Add(Weapon.Axe, 2);
            backpack[Weapon.Spear] = 1;

            /*
                CHALLENGE 3:

                    Add students and grades to your dictionary that you created in CHALLENGE 2.
             
            */
            Random randy = new Random();
            grades = new()
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




            /*   
                ╔══════════════════════════╗ 
                ║ Dictionary<TKey, TValue> ║
                ╚══════════════════════════╝ 

                [  Looping over a Dictionary  ]

                You should use a foreach loop when needing to loop over the entire dictionary.
               
            */
            //for (int i = 0; i < menu.Count; i++)
            //{
            //    menu[i] 
            //}
            Console.WriteLine("Welcome to The Pie Palace");
            foreach (KeyValuePair<string,int> keyValue in menu)
            {
                string name = keyValue.Key;
                int price = keyValue.Value;
                Console.WriteLine($"{price,4:C0} {name}");
            }
            Console.WriteLine();
            foreach (KeyValuePair<Weapon,int> weaponCount in backpack)
                Console.WriteLine($"You have {weaponCount.Value} {weaponCount.Key}");



            /*
                CHALLENGE 4:

                    Loop over your grades dictionary and print each student name and grade.
             
            */
            Console.WriteLine("----------PG2-----------");
            foreach (KeyValuePair<string,double> studentgrade in grades)
            {
                string student = studentgrade.Key;
                double grade = studentgrade.Value;
                Console.ForegroundColor = (grade < 59.5) ? ConsoleColor.Red :
                    (grade < 69.5) ? ConsoleColor.DarkYellow :
                    (grade < 79.5) ? ConsoleColor.Yellow : 
                    (grade < 89.5) ? ConsoleColor.Blue :
                    ConsoleColor.Green;
                Console.Write($"{grade,7:N2} ");
                Console.ResetColor();

                Console.WriteLine($"{student}");
            }





            /*   
                ╔══════════════════════════╗ 
                ║ Dictionary<TKey, TValue> ║
                ╚══════════════════════════╝ 

                [  Checking for a key in a Dictionary  ]

                There are 2 ways to see if a key is in the dictionary:
                1) ContainsKey(key)
                2) TryGetValue(key, out value)
               
            */
            if(backpack.ContainsKey(Weapon.Axe))
                Console.WriteLine($"{Weapon.Axe} count: {backpack[Weapon.Axe]}");

            if(backpack.TryGetValue(Weapon.Spear, out int spearCount))
                Console.WriteLine($"{Weapon.Spear} count: {spearCount}");

            string item = "Apple Pie";
            if (menu.TryGetValue(item, out int cost))
            {
                Console.WriteLine($"{item} costs {cost:C0}");
            }
            else
            {
                menu[item] = 8;
            }

            /*
                CHALLENGE 5:

                    Using either of the 2 ways to check for a key, look for a specific student in the dictionary. 
                    If the student is found, print out the student's grade
                    else print out a message that the student was not found
             
            */







            /*   
                ╔══════════════════════════╗ 
                ║ Dictionary<TKey, TValue> ║
                ╚══════════════════════════╝ 

                [  Updating a value for a key in a Dictionary  ]

                To update an exisiting value in the dictionary, use the [ ]
                
               
            */
            backpack[Weapon.Mace] = 0; //sell all maces



            /*
                CHALLENGE 6:

                    Pick any student and curve the grade (add 5) that is stored in the grades dictionary
             
            */
        }
    }
}
