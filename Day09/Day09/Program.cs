namespace Day09
{
    enum Powers
    {
        Strength, Money, Speed
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Gotham!");

            Calculator t1000 = new();
            int n1 = 5, n2 = 2;
            int sum = t1000.Sum(n1,n2);
            Console.WriteLine($"{n1} + {n2} = {sum}");

            decimal d1 = 10, d2 = 20;
            decimal result = t1000.Sum(d1, d2);
            Console.Write($"{d1} + {d2} = ");
            Console.ForegroundColor = result.GetColor();
            Console.WriteLine(result);
            Console.ResetColor();
        }
    }

    /*  
        ╔═════════════╗ 
        ║ OVERLOADING ║ - polymorphism by changing parameters
        ╚═════════════╝ 

        You can overload a method in 3 ways:
        1) different types on the parameters
        2) different number of parameters
        3) different order of parameters


        CHALLENGE 1:
            Add a overload of the Sum method to sum 2 doubles
    */

    public class Calculator
    {
        public int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

        public double Sum(double d1, double d2)
        {
            return d1 + d2;
        }
    }
}