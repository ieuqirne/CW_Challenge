using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.CardGame
{
    public class PackOfCards : IPackOfCards
    {
        Random random = new Random();
        List<Card> cards = new List<Card>();

        public PackOfCards()
        {

        }
        public void PrintAllCards()
        {
            foreach (Card c in cards)
                Console.WriteLine(c.PrintCard());
        }
        public int Count
        {
            get { return cards.Count(); }
        }


        public IEnumerator<ICard> GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public void addCard(Card card)
        {
            cards.Add(card);
        }
        public void Shuffle()
        {
            int rand;
            for(int x = 0; x < cards.Count; x++)
            {
                rand = random.Next(x + 1);
                Card temp = cards[rand];
                cards[rand] = cards[x];
                cards[x] = temp;
            }
        }


        public ICard TakeCardFromTopOfPack()
        {
            Card temp = cards.FirstOrDefault();
            cards.Remove(temp);
            return temp;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
