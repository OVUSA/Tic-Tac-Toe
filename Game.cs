using System;
using GameBoard;

namespace Logic{
    public class Game{
        int emptyCells = 9;
        //user's represented as player1
        static string player1;
        static string player2;
        private string currentPlayer = player1;
        static Board board;

       public Game(string userSymbol){
            player1 = userSymbol;
            board = new Board();
            board.printBoard();            
        }

        public string switchPlayerTurn(){
            return currentPlayer==player1?currentPlayer=player2:currentPlayer=player1;
        }

        public void gameManager(){
            while(emptyCells>0){
                Console.WriteLine($"It is a {currentPlayer} turn, select the position");
                board.printWithIntexes();
                int userSelec = Console.ReadLine();


            }
        }

        public void assignSymbol(string userSymbol){
            if(userSymbol=="X"){
                player2="O";
                player1="X";
            }else{
                player2="X";
                player1="O";
            }

        }
        
    }
}

