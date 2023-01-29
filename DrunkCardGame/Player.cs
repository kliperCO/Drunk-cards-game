using System;
namespace DrunkCardGame
{
    public class Player
    {
        private string? name;
        private string[] cards;
        public Player()
        {
            Console.WriteLine("What is my name, My Majesty?");
            Console.Write("Your name is ");
            name = Console.ReadLine();
        }

        public string[] Cards
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
    }
}

