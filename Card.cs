using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public enum Suits
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts,

    }
    public enum Value
    {

        Ace = 1,
        Two, Three, Four, Five,
        Six, Seven, Eight, Nine,
        Ten, Jack, Queen, King

    }
    class Card
    {
        public Suits Suit { get; set; }
        public Value Value { get; set; }
        public int card_number { get; set; }
        public int score { get; set; }

        public string Name
        {
            get { return Value.ToString() + " of " + Suit.ToString(); }
        }
        public int getCardScore()
        {
            score = (int)this.Value;
            if ((int)this.Value > 10)
            {
                score = 10;
            }
            if (this.Value == Value.Ace)
            {
                score = 11;
            }
            return score;
        }
        public Card(Suits suit, Value value)
        {
            this.Value = value;
            this.Suit = suit;
        }


    }
}
