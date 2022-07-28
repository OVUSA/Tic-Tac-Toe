using System;
using GameBoard;

namespace Logic{
    public class Game{
        int emptyCells = 9;
        static string player1="Human";
        static string player2 = "Computer";
        string currentPlayer = player1;

       public Game(){
            var board = new Board();
            board.printBoard();            
        }

        public string switchPlayerTurn(){
            return currentPlayer==player1?currentPlayer=player2:currentPlayer=player1;
        }

        public void gameManager(){
            while(emptyCells>0){

            }
        }
    }
}

