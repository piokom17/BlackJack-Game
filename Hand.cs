using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Hand
    {
        public List<Card> cards_in_hand = new List<Card>();
        public int number_of_cards { get; set; }
        public int scoreOfPlayer { get; set; }
        public int scoreOfCard { get; set; }
        public string card_name { get; set; }
        public int initialAmountOfMoney = 300;
        public int cashToBet { get; set; }
        public string result { get; set; }

        public Hand()
        {
            //number_of_cards = numcards;
            cards_in_hand = new List<Card>();
            // trzeba dodac jakos czyste karty
        }
        // funkcja ktora rozdaje karty
        public void Deal(Deck currentDeck)
        {
            // numcards = cards.Count;
            if (currentDeck.cards.Count <= 2)
            {
                currentDeck.loadDeck();

            }
            int pickedCard = 0;
            Card currentCard = currentDeck.cards.ElementAt(pickedCard);
            cards_in_hand.Add(currentCard);
            scoreOfCard = currentCard.getCardScore();
            card_name = currentCard.Name;
            currentDeck.cards.Remove(currentCard);
            
        }
        public string printCardName()
        {
            return card_name;
        }
        
        //funckja ktora porownuje wyniki napoczatku metoda, potem moze interfejs
        public string getResult()
        {
            scoreOfPlayer += scoreOfCard;
            return scoreOfPlayer.ToString();

        }
       
    }
}
