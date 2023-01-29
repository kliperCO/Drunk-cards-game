using System;
using System.Numerics;

namespace DrunkCardGame
{
	public class Program
	{
        static void Main(string[] args)
        {
            Player bot_1 = new Player();
            bot_1.Cards = Cards.PickSomeCards(18);
            bot_1.Memory(bot_1, "/Users/andreyefimik/Projects/DrunkCardGame/DrunkCardGame/bot_1.txt", 18);

            Player bot_2 = new Player();
            bot_2.Cards = Cards.PickSomeCards(18);
            bot_2.Memory(bot_2, "/Users/andreyefimik/Projects/DrunkCardGame/DrunkCardGame/bot_2.txt", 18);
        }
    }
}

