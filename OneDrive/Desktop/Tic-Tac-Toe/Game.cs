using System;
namespace Logic{
    public class Game{
        string player1;
        string player2;
        public Game(){
            this.player1= "Joe";
            this.player2="Mary";           
        }
        
        public void init(){
            Console.Write("Game is on");
        }

        public void players(){
            Console.Write($"The first player is {player1} and second player is {player2}");
        }

    }
}