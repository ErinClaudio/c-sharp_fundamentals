using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Bank
    {
        int bankValue;
        int bet;

        public int Bet
        {
            get{ return bet;}
            set
            {
                if (value <= bankValue)
                {
                    bet = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("You don't have that many chip!");
                }    
            }
        }

        public int BankValue
        {
            get{ return bankValue;}
        }
        
        public Bank(int buyIn)
        {
            bankValue = buyIn;
            bet = 0;
        }


        public void WinBet()
        {
            bankValue += bet;
        }

        public void LoseBet()
        {
            bankValue -= bet;        
        }
    }
}
