using System;
using System.Collections.Generic;

namespace deckofcards
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            // Console.WriteLine("Please Enter the Number of Players:");
            // String num_Players = Console.ReadLine();
            // int number_players = 0;
            // while(number_players == 0){
            //     try{
            //         number_players = Convert.ToInt32(num_Players);
            //     }
            //     catch (FormatException){
            //         Console.WriteLine("Input string is not a sequence of digits.");
            //     }
            // }
            // for (int i  = 1; i<=number_players; i++){
            //     Console.WriteLine("Enter Player" + i + "Name:");
            //     List<string> players = new List<string>();
            //     players.Add(new Player(Console.ReadLine()));
            // }
            // Console.WriteLine(players);
            Player Dealer = new Player("Dealer");
            Player Player1 = new Player("Player 1");
            myDeck.Shuffle();
            Dealer.DrawFrom(myDeck, 2);
            Player1.DrawFrom(myDeck, 2);
            Console.WriteLine("Your Hand: Dealer Showing:" + Dealer.handsum as String);
            Console.WriteLine("Dealer's Hand:");
            Console.WriteLine("________");
            for (int i = 1; i<Dealer.hand.Count; i++){
                Console.WriteLine(Dealer.hand[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Your Hand:" + Player1.handsum as String);
            for (int i = 0; i<Player1.hand.Count; i++){
                Console.WriteLine(Player1.hand[i]);
            }
        }
    }
}
