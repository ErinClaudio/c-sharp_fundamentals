using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Hand
    {
        private List<Card> cards;
        private List<Card> aces;
        private int value;
        private bool isDealer;

        public int Value
        {
            get { return value; }
           
        }

        public bool IsBust
        {
            get{ return value > 21;}
        }

        public bool MustHit
        {
            get{ return value < 17 && isDealer;}
        }
        
        public Hand(Card card1, Card card2, bool isDealer = false)
        {
            this.isDealer = isDealer; 
            cards = new List<Card>();
            aces = new List<Card>();
            Draw(card1);
            Draw(card2);
        }

        public void Draw(Card card)
        {
            cards.Add(card);
            if(card.Rank == Card.Ranks.Ace)
            {
                aces.Add(card);
            }
            setValue();
        }

        private void setValue()
        {
            value = 0;
            var aceCount = aces.Count;
            foreach(var card in cards)
            {
                value += card.Value;
            }
            while(value > 21 && aceCount > 0)
            {
                value = value - 10;
                aceCount--;
            } 
        }
    }
}