using Newtonsoft.Json;

namespace Day10
{

    /*
        ╔══════════╗ 
        ║ File I/O ║
        ╚══════════╝ 

        3 things are required for File I/O:
        1) Open the file
        2) read/write to the file
        3) close the file


        TIPS:
            use File.ReadAllText to open,read,close the file in 1 statement
            the using() statement can ensure that the file is closed

    */

    enum Superpower
    {
        Money, Health, Invisibility, IQ, LaserVision, Flight, Speed, Strength, Swimming
    }
    class Superhero
    {
        public string Name { get; set; }
        public string SecretIdentity { get; set; }
        public Superpower Power { get; set; }
        public int Level { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                ╔══════════╗ 
                ║ File I/O ║
                ╚══════════╝ 

                [  Open the file  ]
                [  Write to the file  ]
                [  Close the file  ]
             
                you need the path to the file
                    use full path ( drive + directories + filename )
                    or use relative path ( directories + filename )
                    or current directory ( filename )


                
                using (StreamWriter sw = new StreamWriter(filePath)) // this line opens the file to write to it
                {                
                    //these lines write to the file
                    sw.Write("Batman");
                    sw.Write(54);
                    sw.Write(13.7);
                    sw.Write(true);

                }//this closes the file

            */

            string directories = @"C:\temp\2301"; //use @ in front of the string to ignore escape sequences inside the string
            string fileName = "tempFile.txt";
            string filePath = Path.Combine(directories, fileName); //use Path.Combine to get the proper directory separators

            //CSV data
            char delimiter = '*';
            //1. open the file
            using (StreamWriter sw = new StreamWriter(filePath)) //IDisposable
            {
                //2. write the data
                sw.Write("Batman rules!");
                sw.Write(delimiter);
                sw.Write(5);
                sw.Write(delimiter);
                sw.Write(13.420);
                sw.Write(delimiter);
                sw.Write("Aquaman stinks!");
            }//3. CLOSE THE FILE!



            /*
                ╔═══════════════════╗ 
                ║ Splitting Strings ║
                ╚═══════════════════╝ 

                taking 1 string a separating it into multiple pieces of data

                use the string's Split method

            */
            string csvString = "Batman;Bruce Wayne;Bats;;;The Dark Knight?Joker?Riddler?Aquaman";
            char[] delims = { ';', '?' };
            string[] data = csvString.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            int index = 0;
            foreach (var item in data)
            {
                Console.WriteLine($"{++index}. {item}");
            }
            Console.WriteLine();
            /*
                CHALLENGE 1:

                    read the data in from the file above and split the line to get the data
             
            */
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line = sr.ReadLine();
                string[] info = line.Split(delimiter);
                for (int i = 0; i < info.Length; i++)
                {
                    Console.WriteLine(info[i]);
                }
            }

            string[] fileData = File.ReadAllText(filePath).Split(delimiter);//opens, reads, closes the file





            /*
                ╔═════════════╗ 
                ║ Serializing ║
                ╚═════════════╝ 

                Saving the state (data) of objects

            */

            List<Superhero> JLA = new List<Superhero>();
            JLA.Add(new Superhero() { Name = "Batman", SecretIdentity = "Bruce Wayne", Power = Superpower.Money, Level = 1000 });
            JLA.Add(new Superhero() { Name = "Wonder Woman", SecretIdentity = "Diana Prince", Power = Superpower.Strength, Level = 999 });
            JLA.Add(new Superhero() { Name = "Flash", SecretIdentity = "Barry Allen", Power = Superpower.Speed, Level = 900 });
            JLA.Add(new Superhero() { Name = "Superman", SecretIdentity = "Clark Kent", Power = Superpower.Flight, Level = 800 });
            JLA.Add(new Superhero() { Name = "Green Lantern", SecretIdentity = "Hal Jordan", Power = Superpower.LaserVision, Level = 10 });
            JLA.Add(new Superhero() { Name = "Aquaman", SecretIdentity = "Arthur Curry", Power = Superpower.Swimming, Level = 1 });

            string jsonFile = Path.ChangeExtension(fileName, "json");
            using (StreamWriter sw = new StreamWriter(jsonFile))
            {
                using (JsonTextWriter jtw = new JsonTextWriter(sw))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Formatting = Formatting.Indented;
                    serializer.Serialize(jtw, JLA);
                }
            }



            /*
                ╔═══════════════╗ 
                ║ Deserializing ║
                ╚═══════════════╝ 

                Recreating the objects from the saved state (data) of objects

            */
            //1. open/read the json text
            if (File.Exists(jsonFile))
            {
                try
                {
                    string heroText = File.ReadAllText(jsonFile);
                    List<Superhero> heroes = JsonConvert.DeserializeObject<List<Superhero>>(heroText);

                    Console.WriteLine("----------Justice League------------");
                    foreach (var hero in heroes)
                    {
                        Console.WriteLine($"{hero.Name} ({hero.SecretIdentity}) Level {hero.Level} Power: {hero.Power}");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"{jsonFile} is the wrong format.");
                }
            }
        }
    }
}