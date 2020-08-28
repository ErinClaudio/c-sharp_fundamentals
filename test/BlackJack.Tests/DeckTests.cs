using System;
using Xunit;

namespace BlackJack.Tests
{
    public class DeckTests
    {
        [Fact]
        public void new_deck_has_52_cards()
        {
            var d1 = new Deck();
            int val = d1.CardCount;
            Assert.Equal(52, val);
        }

        [Fact]
        public void deal_returns_random_card()
        {
            var d1 = new Deck();
            var c1 = d1.Deal();
            var c2 = d1.Deal();
            Assert.NotEqual(c1, c2);
        }

        [Fact]
        public void dealt_card_not_in_deck()
        {
            var d1 = new Deck();
            var c1 = d1.Deal();
            Assert.DoesNotContain(c1, d1.Cards);
        } 
    }
}
