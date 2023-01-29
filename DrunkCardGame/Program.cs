using System;
using System.Numerics;

namespace DrunkCardGame
{
	public class Program
	{
        static void Main(string[] args)
        {
            Player bot_1 = new Player();
            bot_1.Cards = Cards.PickSomeCards(16);
            StreamWriter str = new StreamWriter("/Users/andreyefimik/Projects/Drunk/bot_1.txt");
            for (int i = 0; i < 16; i++)
            {
                str.WriteLine(bot_1.Cards[i]);
            }
            str.Close();

            Player bot_2 = new Player();
            bot_2.Cards = Cards.PickSomeCards(16);


        }
    }
}

