using System;
using GameBoard;

namespace Logic{
    public class Game{
        int emptyCells = 9;
        //user's represented as player1
        static string player1;
        static string player2;
        public string currentPlayer;
        public Board board;

       public Game(string userSymbol){
            
            board = new Board();
            assignSymbol(userSymbol);
            gameManager();
      
        }

        public string switchPlayerTurn(){
            return currentPlayer==player1?currentPlayer=player2:currentPlayer=player1;
        }

        public void gameManager(){

            while(emptyCells>0){
                board.printBoard();  
                Console.WriteLine($"It is a '{currentPlayer}' turn, select the position");
                board.printWithIndexes();
                Console.WriteLine("Enter the number of the cell:");
                string userSelec = Console.ReadLine();
                var temp = Convert.ToInt32(userSelec);
                if(checkInput(temp)!= null){
                    completeMove(checkInput(temp),currentPlayer);
                    emptyCells--;
                    switchPlayerTurn();
                }else{
                    Console.WriteLine("Wrone input, select a cell 0-9");
                }

            }
        }

        public void assignSymbol(string userSymbol){
            if(userSymbol=="X"){
                player2="O";
                player1="X";
                currentPlayer=player1;
            }else{
                player2="X";
                player1="O";
                currentPlayer=player2;
            }

        }
        
        public int[] checkInput(int cell){                     
            switch(cell){
                case 0:
                    if(board.checkValue(0,0)==" "){return new int[]{0,0};};
                    break;
                case 1:
                    if(board.checkValue(0,1)==" "){return new int[]{0,1};};
                    break;
                case 2:
                    if(board.checkValue(0,2)==" "){return new int[]{0,2};};
                    break;
                case 3:
                    if(board.checkValue(1,0)==" "){return new int[]{1,0};}
                    break;
                case 4:
                    if(board.checkValue(1,1)==" "){return new int[]{1,1};}
                    break;
                case 5:
                    if(board.checkValue(1,2)==" "){return new int[]{1,2};}
                    break;
                case 6:
                    if(board.checkValue(2,0)==" "){return new int[]{2,0};}
                    break;
                case 7:
                    if(board.checkValue(2,1)==" "){return new int[]{2,1};}
                    break;
                case 8:
                    if(board.checkValue(2,2)==" "){return new int[]{2,2};}
                    break;
                default:
                    return new int[]{};
            }  
            return null;
        }

        public void completeMove(int [] ar, string currentPlayer){
            board.setBoard(ar[0],ar[1],currentPlayer);

        }
        
    }
}

