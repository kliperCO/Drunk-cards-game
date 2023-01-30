using System;
namespace DrunkCardGame
{
    public class Player
    {
        private string? name;
        private List<string> cards = new List<string>();
        //private string[] cards;
        public Player()
        {
            Console.WriteLine("What is my name, My Majesty?");
            Console.Write("Your name is ");
            name = Console.ReadLine();
        }

        public List<string> Cards
        {
            get
            {
                return cards;
            }
            set
            {
                cards = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        internal void Memory(string way)
        {
            StreamWriter str = new StreamWriter(way);
            for (int i = 0; i < Cards.Count; i++)
            {
                str.WriteLine($"{i+1}){Cards[i]}");
            }
            str.Close();
        }

        internal static void ImAWinner(Player p1, Player p2)
        {
            if (p1.Cards.Count == 0 && p2.Cards.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("DRAW");
                Console.ResetColor();
            }
            else if(p1.Cards.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{p2.Name} WIN!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{p1.Name} WIN!");
                Console.ResetColor();
            }
            
        }
    }
}