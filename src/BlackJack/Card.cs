using System.Collections.Generic;

namespace BlackJack
{
    public class Card
    {
        public enum Suits {Hearts, Diamonds, Spades, Clubs};
        public enum Ranks {Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace};
        
        private Suits suit = 0;
        private Ranks rank = 0;
        private int value = 0;

        private int get_value(Ranks rank)
        {
            switch (rank)
            {
                case Ranks.Two:
                    return 2;
                case Ranks.Three:
                    return 3;
                case Ranks.Four:
                    return 4;
                case Ranks.Five:
                    return 5;
                case Ranks.Six:
                    return 6;
                case Ranks.Seven:
                    return 7;
                case Ranks.Eight:
                    return 8;
                case Ranks.Nine:
                    return 9;
                case Ranks.Ten:
                case Ranks.Jack:
                case Ranks.Queen:
                case Ranks.King:
                    return 10;
                case Ranks.Ace:
                    return 11;
                default:
                    return 0;
            }
        }
        
        public Suits Suit
        { 
            get{return this.suit;}
        }

        public Ranks Rank
        { 
            get{return this.rank;}
        }

        public int Value
        { 
            get{return this.value;}
        }
        public Card(Suits suit, Ranks rank)
        {
            this.suit = suit;
            this.rank = rank;
            this.value = get_value(rank);
        }
        
        public override string ToString()
        {
            return this.rank + " of " + this.suit;
        }
    }
}