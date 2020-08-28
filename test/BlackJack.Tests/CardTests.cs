using System;
using Xunit;

namespace BlackJack.Tests
{
    public class CardTests
    {
        [Fact]
        public void Ace_has_a_value_of_11()
        {
            var c1 = new Card(Card.Suits.Spades, Card.Ranks.Ace);
            int val = c1.Value;
            Assert.Equal( 11,c1.Value);
        }
    }
}
