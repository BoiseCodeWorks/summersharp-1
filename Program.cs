using System; //import
using System.Collections.Generic;
using System.Threading;

namespace csharp //organaize your project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //             Console.WriteLine("Hello, what is your name?");
            //             string name = Console.ReadLine();
            //             Console.WriteLine($@"
            // Nice to meet you {name}

            // Lets do some coding eh?
            // ");
            //             int num = 3; //all whole numbers up to 2,147,483,647
            //             double pi = 3.148;
            //             decimal financeStuffNumber = 34.3553645m; //for the money

            //             switch (name.ToLower())
            //             {
            //                 case "mark":
            //                     Console.WriteLine("Yo Dawg");
            //                     break;
            //                 case "darryl":
            //                 case "d$":
            //                     Console.WriteLine("DMONEAYYYYY");
            //                     break;
            //                 default:
            //                     Console.WriteLine("I don't know you");
            //                     break;
            //             }

            //             for (var i = 0; i < 10; i++)
            //             {

            //             }



            //type into console '1d4' and have it return the total of the roll
            //take in a number and return a random number between 1 and that number
            // take in a number of rolls, and repeat step 1 that many times

            string greeting = "I want to play a game, follow the white rabbit neo";
            for (int i = 0; i < greeting.Length; i++)
            {
                Thread.Sleep(100);
                Console.Write(greeting[i]);
            }
            Console.WriteLine();

            bool running = true;
            while (running)
            {
                Console.Write("Please enter the sides of the dice: ");
                string strSides = Console.ReadLine();
                Console.Write("How many times to roll?");
                string strRolls = Console.ReadLine();
                int sides = 0;
                int rolls = 0;
                if (Int32.TryParse(strSides, out sides) && Int32.TryParse(strRolls, out rolls))
                {
                    Random rnd = new Random();
                    for (int i = 0; i < rolls; i++)
                    {
                        Thread.Sleep(500);
                        int roll = rnd.Next(1, sides);
                        System.Console.WriteLine($"You rolled a {roll}");
                    }
                }
                else
                {
                    Console.WriteLine("not a valid number");
                }
                Console.WriteLine("Again (y/n)");
                ConsoleKeyInfo response = Console.ReadKey();
                if (response.KeyChar == 'n')
                {
                    running = false;
                }
                Console.Clear();
            }

            // string[] birds = new string[6];
            // birds[6] = "penguin";
            // birds[6] = null;


            // List<string> dogs = new List<string>(){
            //     "rover",
            //     "fido",
            //     "spot"
            // }; //closer to JS array
            // dogs.Add("BINGO");
            // dogs.Remove("BINGO");

            // dogs.Find(d => d == "rover");
            // dogs.Add("BINGO");

            // System.Console.WriteLine(dogs);

            // dogs.ForEach(d => System.Console.WriteLine(d));


            Dictionary<string, int> BookPages = new Dictionary<string, int>();

            BookPages.Add("Hobbit", 310);
            BookPages.Add("Harry Potter", 452);
            if (BookPages.ContainsKey("JRR Tolkien"))
            {
                int myBookPages = BookPages["JRR Tolkien"];

            }


















        }
    }
}
