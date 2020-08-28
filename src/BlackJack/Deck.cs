using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Deck
    { 
        public List<Card> Cards;
        private Random card_picker;
        
        public int CardCount
        {
            get{return Cards.Count; }
        }

        public Deck()
        {
            Cards = new List<Card>();
            card_picker = new Random();

            var suits = Enum.GetValues(typeof(Card.Suits));
            var ranks = Enum.GetValues(typeof(Card.Ranks));

            // foreach (var suit in suits)
            foreach (Card.Suits suit in suits)
            {
                foreach (Card.Ranks rand in ranks)
                {
                    var card = new Card(suit, rand);
                    Cards.Add(card);
                }
            }
            
            // shuffle();
        }

        // research shuffle 
        // I used randomize a list
        // https://stackoverflow.com/questions/273313/randomize-a-listt
        // private void shuffle()
        // {
        //     var random = new Random();
        //     for(var i=cards.Count; i > 0; i--)
        //         swap_cards(0, random.Next(0, i));
        // }
        // private void swap_cards(int i, int j)
        // {
        //     var temp = cards[i];
        //     cards[i] = cards[j];
        //     cards[j] = temp;
        // }

        public Card Deal()
        {
            var pick = this.card_picker.Next(0,Cards.Count);
            var card = Cards[pick];
            Cards.RemoveAt(pick);

            return card;
        }

        
    }
}
