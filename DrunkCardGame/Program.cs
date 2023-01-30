using System;
using System.Numerics;

namespace DrunkCardGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Player bot_1 = new Player();
            bot_1.Cards = Cards.PickSomeCards(18);
            bot_1.Memory("/Users/andreyefimik/Projects/DrunkCardGame/DrunkCardGame/bot_1.txt");

            Player bot_2 = new Player();
            bot_2.Cards = Cards.PickSomeCards(18);
            bot_2.Memory("/Users/andreyefimik/Projects/DrunkCardGame/DrunkCardGame/bot_2.txt");

            Console.WriteLine();
            Game(bot_1, bot_2);
        }

        static void Game(Player p1, Player p2)
        {
            int sch = 0, schBot_1 = 0, schBot_2 = 0;
            int i = 0, j = 0;
            while (p1.Cards.Count != 0 && p2.Cards.Count != 0)
            {
                if ((i == p1.Cards.Count && p1.Cards.Count > 0) || i > p1.Cards.Count)
                {
                    i = 0;
                }
                if ((j == p2.Cards.Count && p2.Cards.Count > 0) || j > p2.Cards.Count)
                {
                    j = 0;
                }

                Console.WriteLine($"{p1.Cards[i]} VS {p2.Cards[j]}");

                int card_1 = parseStringToInt(p1, i);
                int card_2 = parseStringToInt(p2, j);

                if (card_1 == card_2)
                {
                    p1.Cards.RemoveAt(i);
                    p1.Memory("/Users/andreyefimik/Projects/DrunkCardGame/DrunkCardGame/bot_1.txt");

                    p2.Cards.RemoveAt(j);
                    p2.Memory("/Users/andreyefimik/Projects/DrunkCardGame/DrunkCardGame/bot_2.txt");

                    Console.WriteLine($"{schBot_1} : {schBot_2}\n");
                }
                else if (card_1 < card_2)
                {
                    p2.Cards.Add(p1.Cards[i]);
                    p2.Memory("/Users/andreyefimik/Projects/DrunkCardGame/DrunkCardGame/bot_2.txt");

                    p1.Cards.RemoveAt(i);
                    p1.Memory("/Users/andreyefimik/Projects/DrunkCardGame/DrunkCardGame/bot_1.txt");

                    ++schBot_2;

                    Console.WriteLine($"{schBot_1} : {schBot_2}\n");

                    j++;
                }
                else if (card_1 > card_2)
                {
                    p1.Cards.Add(p2.Cards[j]);
                    p1.Memory("/Users/andreyefimik/Projects/DrunkCardGame/DrunkCardGame/bot_1.txt");

                    p2.Cards.RemoveAt(j);
                    p2.Memory("/Users/andreyefimik/Projects/DrunkCardGame/DrunkCardGame/bot_2.txt");

                    ++schBot_1;

                    Console.WriteLine($"{schBot_1} : {schBot_2}\n");

                    i++;
                }
            }
            Player.ImAWinner(p1, p2);
        }

        static private int parseStringToInt(Player p, int sch)
        {
            int value = 0;

            string[] temp = p.Cards[sch].Split(' ');
            switch (temp[0])
            {
                case "Ace":
                    value = 14;
                    break;

                case "Queen":
                    value = 12;
                    break;

                case "King":
                    value = 13;
                    break;

                case "Jack":
                    value = 11;
                    break;

                default:
                    value = int.Parse(temp[0]);
                    break;
            }
            return value;
        }
    }
}