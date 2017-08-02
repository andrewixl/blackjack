using System;
using System.Collections.Generic;

namespace deckofcards {
    public class Player {
        public string name;
        public List<Card> hand;
        public int handsum;

        public Player(string n) {
            hand = new List<Card>();
            name = n;
            handsum = 0;
        }

        public void DrawFrom(Deck currentDeck, int cards) {
            for (int i = 1; i<= cards; i++){
                hand.Add(currentDeck.Deal());
                Console.WriteLine(hand[hand.Count-1].stringVal);
                try{
                    int val = Convert.ToInt32(hand[hand.Count-1].stringVal);
                    if(val > 1 && val < 11) {
                        handsum = handsum + val;
                    }
                    else if (val == 11) {
                        handsum = handsum + 10;
                    }
                    else if (val == 12) {
                        handsum = handsum + 10;
                    }
                    else if (val == 13) {
                        handsum = handsum + 10;
                    }
                    else if (val == 1) {
                        handsum = handsum + 10;
                    }
                    else {
                        handsum = handsum;
                    }
                }
                catch{
                    String val = hand[hand.Count-1].stringVal;
                    if(val == "Ace") {
                        handsum = handsum + 1;
                    }
                    else if (val == "Jack" || val == "Queen" || val == "King") {
                        handsum = handsum + 10;
                    }
                }
            }
        }
        
        public Card Discard(int idx) {
            Card temp = hand[idx];
            hand.RemoveAt(idx);
            return temp;
        }
    }
}