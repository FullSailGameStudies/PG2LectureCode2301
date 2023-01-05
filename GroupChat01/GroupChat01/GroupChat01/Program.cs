namespace GroupChat01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Bruce", "Batman", "The Dark Knight", "Bats", "The Bat" };


            string name = string.Empty ;
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i].Equals("THE DARK KNIGHT",StringComparison.OrdinalIgnoreCase))
                {
                    name = names[i];
                    break;
                }
            }
            Console.WriteLine($"Found {name}");

            string usersInput = Console.ReadLine();
        }

    }
}