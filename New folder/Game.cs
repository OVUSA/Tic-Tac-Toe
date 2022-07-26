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

       public Game(string userSymbol, string difficultyLevel){          
            board = new Board();
            assignSymbol(userSymbol);
            gameManager();      
        }
        public string switchPlayerTurn(){
            return currentPlayer==player1?currentPlayer=player2:currentPlayer=player1;
        }

        public void gameManager(){

            while(emptyCells>0 && isWinner()==null){
                board.printBoard();

                board.printWithIndexes();  
                if(currentPlayer!=player1){
                    Console.WriteLine("Computer turns......");
                    randomMove();

                }else{
                    Console.WriteLine($"It is a '{currentPlayer}' turn, select the position");
                    Console.WriteLine("Enter the number of the cell:");
                    string userSelec = Console.ReadLine();
                    var temp = Int32.Parse(userSelec);
                    if(checkInput(temp)[0]!= 5){
                        completeMove(checkInput(temp),currentPlayer);
                        emptyCells--;
                        
                    }else{
                        Console.WriteLine("Wrong input, select a cell 0-9");
                    }

                }

             if(isWinner()==null){switchPlayerTurn();}continue;
            }
 
            board.printBoard();
            Console.Write($"The winner is '{currentPlayer}' .Game is over!!");
        }


        public void assignSymbol(string userSymbol){
            if(userSymbol=="X"){
                player2="O";
                player1="X";
            }else{
                player2="X";
                player1="O";
            }
            currentPlayer=player1;

        }
        
        public int[] checkInput(int cell){  
            int[] ret = new int[2];                   
            switch(cell){
        
                case 0:
                    if(board.checkValue(0,0)=="  "){ret[0] =0;ret[1]=0;};
                    break;
                case 1:
                    if(board.checkValue(0,1)=="  "){ret[0] =0;ret[1]=1;};
                    break;
                case 2:
                    if(board.checkValue(0,2)=="  "){ret[0] =0;ret[1]=2;};
                    break;
                case 3:
                    if(board.checkValue(1,0)=="  "){ret[0] = 1;ret[1]= 0;}
                    break;
                case 4:
                    if(board.checkValue(1,1)=="  "){ ret[0] = 1;ret[1]= 1;}
                    break;
                case 5:
                    if(board.checkValue(1,2)=="  "){ ret[0] = 1;ret[1]= 2;}
                    break;
                case 6:
                    if(board.checkValue(2,0)=="  "){ret[0] = 2;ret[1]= 0;}
                    break;
                case 7:
                    if(board.checkValue(2,1)=="  "){ret[0] = 2;ret[1]= 1;}
                    break;
                case 8:
                    if(board.checkValue(2,2)=="  "){ret[0] = 2;ret[1]= 2;}
                    break;
                default:
                    ret[0] = 5;ret[1]= 5;
                    break;
            }
            return ret;
            
   
        }

        public void randomMove(){
  
        Random rnd = new Random();
        int num = rnd.Next(0,8); 
            if(checkInput(num)!=null){
                completeMove(checkInput(num), currentPlayer);
            }
        Console.WriteLine($"Computer completed the move.. its selected: {num}");
                   
        }
        public string isWinner(){
            if(board.checkValue(0,0)==board.checkValue(1,1)&&board.checkValue(1,1)== board.checkValue(2,2)&& board.checkValue(1,1)!="  "){
                return board.checkValue(1,1);}

            else if (board.checkValue(0,0)==board.checkValue(0,1)&&board.checkValue(0,1)== board.checkValue(0,2)&& board.checkValue(0,0)!="  "){
                return board.checkValue(0,1);}

            else if (board.checkValue(0,0)==board.checkValue(1,0)&&board.checkValue(1,0)== board.checkValue(2,0)&& board.checkValue(0,0)!="  "){
                return board.checkValue(1,0);}

            else if (board.checkValue(0,1)==board.checkValue(1,1)&&board.checkValue(1,1)== board.checkValue(2,1)&& board.checkValue(1,1)!="  "){
                return board.checkValue(1,1);}
            
            else if (board.checkValue(0,2)==board.checkValue(1,2)&&board.checkValue(1,2)== board.checkValue(2,2)&& board.checkValue(1,2)!="  "){
                return board.checkValue(1,2);}       
                    
            else if (board.checkValue(1,0)==board.checkValue(1,1)&&board.checkValue(1,1)== board.checkValue(1,2)&& board.checkValue(1,2)!="  "){
                return board.checkValue(1,1);}

            else if (board.checkValue(2,0)==board.checkValue(1,1)&&board.checkValue(1,1)== board.checkValue(0,2)&& board.checkValue(0,2)!="  "){
                return board.checkValue(1,1);}
            
            else if (board.checkValue(0,2)==board.checkValue(1,2)&&board.checkValue(1,2)== board.checkValue(2,2)&& board.checkValue(1,2)!="  "){
                return board.checkValue(1,2);}
            
            else if ( board.checkValue(2,2)!="  "&& board.checkValue(2,0)==board.checkValue(2,1)&&board.checkValue(2,1)== board.checkValue(2,2)){
                return board.checkValue(2,1);}
            else
                return null;
        }

        public void completeMove(int [] ar, string currentPlayer){
            board.setBoard(ar[0],ar[1],currentPlayer);

        }
        
    }
}
/*_____________
| 00 | 01 | 02 |
_____________
| 10 | 11 | 12 |
_____________
| 20 | 21 | 22 | ++

*/

