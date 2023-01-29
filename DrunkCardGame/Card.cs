using System;
namespace DrunkCardGame
{
    public class Cards
    {
        static Random rand = new Random();
        static private string value;
        static private string suit;
        static private List<string> noCardsRepeat = new List<string>();
   
        public static string[] PickSomeCards(int numOfCards)
        {
            string[] pickedCards = new string[numOfCards];
            for (int i = 0; i < numOfCards; i++)
            {
                pickedCards[i] = CheckCards();
            }
            return pickedCards;
        }

        //private static string RandomCards()
        //{

        //}

        private static string RandomValue()
        {
            int value = rand.Next(6, 15);
            if (value == 11) return "Ace";
            if (value == 12) return "King";
            if (value == 13) return "Queen";
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

        private static string CheckCards()
        {
            string text = RandomValue() + " of " + RandomSuit();
            int size = noCardsRepeat.Count;
            int sch = 0;
            if(size != 0)
            {
                while(sch < size)
                {
                    if (text == noCardsRepeat[sch])
                    {
                        text = RandomValue() + " of " + RandomSuit();
                        sch = 0;
                    }
                    else sch++;
                }
            }
            noCardsRepeat.Add(text);
            size = noCardsRepeat.Count;

            StreamWriter str = new StreamWriter("/Users/andreyefimik/Projects/DrunkCardGame/DrunkCardGame/noCardsRepeat.txt");
            for (int i = 0; i < size; i++)
            {
                str.WriteLine($"{i + 1}){noCardsRepeat[i]}");
            }
            str.Close();

            return text;
        }
    }
}