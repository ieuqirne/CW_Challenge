using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.CardGame
{
    public class PackOfCardsCreator : IPackOfCardsCreator
    {
        public IPackOfCards Create()
        {
            PackOfCards pack = new PackOfCards();
            Card newCard;
            int suit, value;
            Suit s = Suit.Clubs;
            Value v = Value.Ace;

            for(int x = 0; x < 52; x++)
            {
                suit = x / 13;
                value = x % 13;

                switch (suit)
                {
                    case 0:
                        s = Suit.Clubs;
                        break;
                    case 1:
                        s = Suit.Diamonds;
                        break;
                    case 2:
                        s = Suit.Hearts;
                        break;
                    case 3:
                        s = Suit.Spades;
                        break;
                }
                switch (value)
                {
                    case 0:
                        v = Value.Ace;
                        break;
                    case 1:
                        v = Value.Two;
                        break;
                    case 2:
                        v = Value.Three;
                        break;
                    case 3:
                        v = Value.Four;
                        break;
                    case 4:
                        v = Value.Five;
                        break;
                    case 5:
                        v = Value.Six;
                        break;
                    case 6:
                        v = Value.Seven;
                        break;
                    case 7:
                        v = Value.Eight;
                        break;
                    case 8:
                        v = Value.Nine;
                        break;
                    case 9:
                        v = Value.Ten;
                        break;
                    case 10:
                        v = Value.Jack;
                        break;
                    case 11:
                        v = Value.Queen;
                        break;
                    case 12:
                        v = Value.King;
                        break;

                }
                //Console.WriteLine("created : " + v + s);
                newCard = new Card(v, s);
                pack.addCard(newCard);
            }
            return pack;
        }
    }
}
