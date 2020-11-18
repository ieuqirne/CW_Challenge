using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.CardGame
{
    public class Card : ICard
    {
        Suit suit;
        Value value;

        public Card(Value v, Suit s)
        {
            value = v;
            suit = s;
        }
        public string PrintCard()
        {
            string nameCard = value + " of "+ suit;

            return nameCard;
        }
        public Suit Suit => throw new NotImplementedException();

        public Value Value => throw new NotImplementedException();

        public bool Equals(ICard other)
        {
            throw new NotImplementedException();
        }
    }
}
