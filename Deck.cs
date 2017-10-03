﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {
        public List<Card> cards;
        Random random = new Random();


        //konstruktor tworzący pelna talie kart
        public Deck()
        {
            cards = new List<Card>();
            loadDeck();
        }
        public void loadDeck()
        {
            cards.Clear();
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    cards.Add(new Card((Suits)suit, (Value)value));
                }

            }

        }

        public Card FindCard(int cardnum)
        {
            foreach (Card cardToFind in cards)
            {
                if (cardToFind.card_number == cardnum)
                    return cardToFind;
            }
            return null;

        }
        /* public Card Deal(int index)
         {
             Card CardToDeal = cards[index];
             cards.RemoveAt(index);
             return CardToDeal;

         }
         //jezeli nie przekazujemy metodzie zadnych parametrow bedzie pobierala element z gory listy czyli pierwsza karte :)
         public Card Deal()
         {
             return Deal(0);
         }
         //dodaje karte do listy
         public void Add(Card cardToAdd)
         {
             cards.Add(cardToAdd);
         }
         // odejmuje karte z listy
         public Card Remove(int index)
         {
             Card CardToRemove = cards[index];
             cards.RemoveAt(index);
             return CardToRemove;
         }
         */
        //tasowanie - shuffle
        public void Shuffle()
        {
            List<Card> NewCards = new List<Card>();
            while (cards.Count > 0)
            {
                int CardToMove = random.Next(cards.Count);
                NewCards.Add(cards[CardToMove]);
                cards.RemoveAt(CardToMove);
            }
            cards = NewCards;
        }

        /* public IEnumerable<string> GetCardNames()
         {
             string[] CardNames = new string[cards.Count];
             for(int i=0; i <cards.Count;i++)
             {
                 CardNames[i] = cards[i].Name;

             }
             return CardNames;
         }
         * */
    }
}
