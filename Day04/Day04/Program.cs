using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Day04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Recursion, Sorting, Searching

            /*
                ╔═════════╗ 
                ║Recursion║
                ╚═════════╝ 
             
                Recursion happens when a method calls itself. This creates a recursive loop.
                
                All recursive methods need an exit condition, something that prevents the loop from continuing.
              
            */
            int N = 0;
            //RecursiveLoop(N);
            Console.ResetColor();


            /*
                CHALLENGE 1:

                    convert this for loop to a recursive method called Bats. Call Bats here in Main.
             
                    for(int i = 0;i < 100;i++)
                    {
                        Console.Write((char)78);
                        Console.Write((char)65);
                        Console.Write(' ');
                    }
            */





            /*
                ╔═══════╗ 
                ║Sorting║
                ╚═══════╝ 
             
                Sorting is used to order the items in a list/array is a specific way
             
                CHALLENGE 2:

                    Convert this BubbleSort pseudo-code into a C# method             
                     
                    procedure bubbleSort(A : list of sortable items)
                      n := length(A)
                      repeat
                          swapped := false
                          for i := 1 to n - 1 inclusive do
                              if A[i - 1] > A[i] then
                                  swap(A, i - 1, i)
                                  swapped = true
                              end if
                          end for
                          n := n - 1
                      while swapped
                    end procedure
                    
            */

            string s1 = "Batman", s2 = "Batmen";
            //s1.CompareTo(s2)
            //  returns 3 possible values:
            //  -1  less than
            //   0  equal
            //   1  greater than
            int result = s1.CompareTo(s2);
            if (result == 0) Console.WriteLine($"{s1} EQUALS {s2}");
            else if(result == -1) Console.WriteLine($"{s1} LESS THAN {s2}");
            else if (result == 1) Console.WriteLine($"{s1} GREATER THAN {s2}");

            List<int> numbers = new List<int>() { 5, 4, 3, 2, 1 };
            List<string> names = new() { "Bruce", "Clark", "Adam", "Dave", "Bob"};
            BubbleSort(names);
            foreach(string name in names)
                Console.WriteLine(name);
            //numbers.Sort();

        }
        static void BubbleSort(List<string> A)
        {
            int n = A.Count;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i <= n-1; i++)
                {
                    if (A[i - 1].CompareTo(A[i]) > 0)
                    {
                        //swap logic
                        //Swap(A[i- 1], A[i]);
                        //int temp = A[i - 1];
                        //A[i - 1] = A[i];
                        //A[i] = temp;
                        (A[i], A[i-1]) = (A[i-1], A[i]);
                        swapped = true;
                    }
                }
                //  n = n - 1;
                --n;
            } while (swapped);
        }


        static void RecursiveLoop(int N)
        {
            //an Exit Condition. This will stop the loop when N >= Console.WindowWidth
            if (N < Console.WindowWidth)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(' ');
                Thread.Sleep(20);

                RecursiveLoop(N + 1);//calls itself which makes the method recursive

                Thread.Sleep(20);
                Console.CursorLeft = N;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write(' ');
            }
        }
    }
}
