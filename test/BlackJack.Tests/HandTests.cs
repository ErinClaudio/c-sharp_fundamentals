using System;
using Xunit;

namespace BlackJack.Tests
{
    public class HandTests
    {
        [Fact]
        public void over_21_is_bust()
        {
            var card1 = new Card(Card.Suits.Spades, Card.Ranks.Jack);
            var card2 = new Card(Card.Suits.Hearts, Card.Ranks.King);
            var card3 = new Card(Card.Suits.Diamonds, Card.Ranks.Two);
           
            var hand = new Hand(card1, card2);
            Assert.False(hand.IsBust);
            hand.Draw(card3);
            Assert.True(hand.IsBust);
        }

    }
}
