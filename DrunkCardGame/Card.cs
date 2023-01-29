using System;
namespace DrunkCardGame
{
    public class Cards
    {
        static Random rand = new Random();
        static private string value;
        static private string suit;
        static private List<string> cardExist = new List<string>();
        //static private string[] cardExist = {null};

        public static string[] PickSomeCards(int numOfCards)
        {
            string[] pickedCards = new string[numOfCards];
            for (int i = 0; i < numOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
                cardExist.Add(pickedCards[i]);
                Console.WriteLine($"{cardExist[i]}");
            }
            return pickedCards;
        }

        private static string RandomValue()
        {
            int value = rand.Next(6, 15);
            if (value == 11) return "Ace";
            if (value == 12) return "King";
            if (value == 13) return "Quen";
            if (value == 14) return "Jack";
            return value.ToString();
        }

        private static string RandomSuit()
        {
            int suit = rand.Next(1, 5);
            if (suit == 1) return "Spades♠";
            if (suit == 2) return "Hearts❤";
            if (suit == 3) return "Clubs♣";
            return "Diamonds♦";
        }
    }
}

