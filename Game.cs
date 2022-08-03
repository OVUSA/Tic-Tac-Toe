using System;
using GameBoard;

namespace Logic{
    public class Game{
        int emptyCells = 9;
        //user's represented as player1
        static string player1;
        static string player2;
        public string currentPlayer = player1;
        public Board board;

       public Game(string userSymbol){
            player1 = userSymbol;
            board = new Board();
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
                string userSelec = Console.ReadLine();
                var temp = Convert.ToInt32(userSelec);
                if(checkInput(temp)!= null){
                    completeMove(temp);
                }



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
        public int[] checkInput(int cell){                     
            switch(cell){
                case 0:
                    if(board.checkValue(0,0)==" "){return new int[]{0,0};};
                    break;
                case 1:
                    if(board.checkValue(0,1)==" "){return true;};
                    break;
                case 2:
                    if(board.checkValue(0,2)==" "){return true;};
                    break;
                case 3:
                    if(board.checkValue(1,0)==" "){return true;}
                    break;
                case 4:
                    if(board.checkValue(1,1)==" "){return true;}
                    break;
                case 5:
                    if(board.checkValue(1,2)==" "){return true;}
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                default:
                    return null;
            }
   
            
        }

        public void completeMove(int cell){
            board.setBoard()

        }
        
    }
}

