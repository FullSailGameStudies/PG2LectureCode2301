using System;
using System.Collections.Generic;

namespace Day01
{
    /*                    METHODS          
                                                               
                ╔══════╗ ╔═══╗ ╔══════════╗ ╔════════════════╗ 
                ║public║ ║int║ ║SomeMethod║ ║(int someParam) ║ 
                ╚══════╝ ╚═══╝ ╚══════════╝ ╚════════════════╝ 
                    │      │         │               │         
              ┌─────┘      │         └──┐            └───┐     
         ┌────▼────┐   ┌───▼───┐   ┌────▼───┐       ┌────▼────┐
         │ Access  │   │ Return│   │ Method │       │Parameter│
         │ modifier│   │ type  │   │  Name  │       │  list   │
         └─────────┘   └───────┘   └────────┘       └─────────┘


    
    ╔═══════════╗ 
    ║Return type║ Return type defines the type of the data being returned.
    ╚═══════════╝
    │
    │
    └── If NO data is returned, then use "void" for the return type.
    │    public void PrintSomething()
    │    {
    │        Console.WriteLine("Something");
    │    }
    │
    │
    └── If a method returns data, then the return type must match the type of the data being returned.
        public float GetMyGrade()
        {
            return 99.9F; //returning a float so set return type to float
        }

    ╔══════════╗ 
    ║Parameters║ Parameters define the data passed to the method.
    ╚══════════╝
    │
    │
    └── If NO data is passed to the method, leave the parenthesis empty. EX: ( )
    │    public void PrintSomething()
    │   {  }
    │
    │
    └── If passing data to the method, then define the variable the method will use to store the data.
        Parameters are just variables therefore parameters need 2 things: <type> <name>
        Example:
        public void PrintMyGrade(float myGrade)
        {
            Console.WriteLine($"My grade is {myGrade}");
        }

        

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
              Calling a method
                use the methods name.
                1) if the method needs data (i.e. has parameters), you must pass data to the method that matches the parameter types
                2) if the method returns data, it is usually best to store that data in a variable on the line where you call the method.
             
            */
            int hz = 12000;
            int duration = 1500;
            Console.Beep(hz, duration);
            string someData = Console.ReadLine();

            //$ - C# interpolated string
            Console.WriteLine($"You typed {someData}. Odd.");

            /*
                ╔══════════════════════════╗ 
                ║Parameters: Pass by Value.║ (COPY)
                ╚══════════════════════════╝ 
             
                Copies the value to a new variable in the method.
                
                For example, the AddOne method has a parameter called localNumber. localNumber is a variable that is local ONLY to the method.
                The value of the variable in main, number, is COPIED to the variable in AddOne, localNumber.
              
            */
            int number = 5;
            int plusOne = AddOne(number);

            /*
                CHALLENGE 1:

                    call the Sum method on the t1000 calculator. Print the sum that is returned.
             
            */
            Calculator t1000 = new Calculator();
            //int result = t1000.Sum(number, plusOne);
            Console.WriteLine($"The sum of {number} and {plusOne} is {t1000.Sum(number, plusOne)}");


            #region Lists

            Console.WriteLine("---------FOR--------");
            int[] nums = new int[] { 1, 2, 3, 4, 5 };//good for non-changing amount of data
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);//indexer is O(1)
            }
            Console.WriteLine("-----FOREACH------");
            //anonmyous type
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
            //resize the array
            int[] temp = new int[nums.Length + 2];
            for (int i = 0; i < nums.Length; i++)//custom code to copy the data
            {
                temp[i] = nums[i];
            }
            nums = temp;//KHANS to arrays -- duplicated data

            /*   
                ╔═════════╗ 
                ║ List<T> ║
                ╚═════════╝ 
                
                [  Creating a List  ]
                
                List<T>  - the T is a placeholder for a type. It is a "Generic Type Parameter" to the class.
                
                When you want to create a List variable, replace T with whatever type of data you want to store in the List.
            */
            List<string> names = new List<string>(10); //this list stores strings and only strings.

            names.Add("Batman"); //how big is the internal array?
            Info(names); //Count: 1  Capacity: 10
            names.Add("Bruce");
            names.Add("Bats");
            names.Add("The Bat");//Count: 4  Capacity: 10
            names.Add("Joker");//Count: 5  Capacity: 10
            Info(names); //Count: 5  Capacity: 10
            names.Add("Superman");
            names.Add("Bane");
            names.Add("Man-Bat");
            names.Add("Robin");
            Info(names); //Count: 9  Capacity: 10
            names.Add("Alfred");
            names.Add("Mr. Freeze");
            Info(names); //Count: 11  Capacity: 20
            //Console.WriteLine(names[15]);//??? index-out-of-range
            /*
                CHALLENGE 2:

                    Create a list that stores floats. Call the variable grades.
             
            */
            //variables: <type> <name>
            List<float> grades;//0? nothing? null
            grades = new(); //empty list.

            //Count - # of items added to the list
            //Capacity - length of the internal array


            /*   
                ╔═════════╗ 
                ║ List<T> ║
                ╚═════════╝ 

                [  Adding items to a List  ]

                There are 2 ways to add items to a list:
                1) on the initializer. 
                2) using the Add method. 
            */
            List<char> letters = new List<char>() { 'B', 'a', 't', 'm', 'a', 'n' };
            letters.Add('!');//adds to the end of the list

            /*
                CHALLENGE 3:

                    Add a few grades to the grades list you created in CHALLENGE 2.
             
            */
            grades = new() { GetGrade(), GetGrade() };
            grades.Add(GetGrade());
            grades.Add(GetGrade());
            grades.Add(GetGrade());
            grades.Add(GetGrade());





            /*   
                ╔═════════╗ 
                ║ List<T> ║
                ╚═════════╝ 

                [  Looping over a List  ]

                You can loop over a list with a for loop or a foreach loop.
                1) for loop. use the Count property in the for condition.
                2) foreach loop
            */
            for (int i = 0; i < letters.Count; i++)
                Console.Write($" {letters[i]}");

            foreach (var letter in letters)
                Console.Write($" {letter}");

            /*
                CHALLENGE 4:

                    1) Fix the Average method of the calculator class to calculate the average of the list parameter.
                    2) Call the Average method on the t1000 variable and pass your grades list to the method.
                    3) print the average that is returned.
             
            */
            float average = t1000.Average(grades);
            Console.WriteLine("\n\n--------2301 GRADES----------");
            for (int x = 0; x < grades.Count; x++)
            {
                //,7 - right-align with 7 spaces
                //:N2 - number w/ 2 decimal places
                float grade = grades[x];
                if (grade < 59.5) Console.ForegroundColor = ConsoleColor.Red;
                else if (grade < 69.5) Console.ForegroundColor = ConsoleColor.DarkYellow;
                else if (grade < 79.5) Console.ForegroundColor = ConsoleColor.Yellow;
                else if (grade < 89.5) Console.ForegroundColor = ConsoleColor.Blue;
                else Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{grade,7:N2}");
            }
            Console.ResetColor();
            Console.WriteLine($"Average grade: {average}");
            #endregion


            Console.ReadKey(true);
        }

        static Random rando = new Random();
        private static float GetGrade()
        {
            return (float)rando.NextDouble() * 100;
        }

        private static void Info(List<string> names)
        {
            Console.WriteLine($"Count: {names.Count}\tCapacity: {names.Capacity}");
        }

        private static int AddOne(int localNumber)
        {
            localNumber *= 2;//only affects this local variable
            return localNumber + 1;
        }


    }

    class Calculator
    {
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }


        public float Average(List<float> numbers)
        {
            float avg = 0F;

            //loop over the numbers and calculate the average
            foreach (var number in numbers)
            {
                avg+= number;
            }
            avg /= numbers.Count;

            return avg;
        }
    }
}
