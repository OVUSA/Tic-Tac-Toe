namespace GameBoard{
    public class Board {
        private String[,] board;

        public Board(){
            board = new String[,]{
                {"  ", "  ", "  "},
                {"  ", "  ", "  "},
                {"  ", "  ", "  "}
            };
        }
    
        public void printBoard(){
            Console.WriteLine("________________");
            for( int i = 0;i< 3;i++){
                for ( int j = 0;j<3;j++){
                    Console.Write("|");
                    Console.Write( " " +board[i,j]+" ");                
                }
                Console.WriteLine("|");
                Console.WriteLine("________________");
            }
        }
        public void printWithIndexes(){
            int m =0;
                        Console.WriteLine("_____________");
            for( int i = 0;i< 3;i++){
                for ( int j = 0;j<3;j++){
                    Console.Write("|");
                    Console.Write( " " +m+" ");   
                    m++;             
                }
                Console.WriteLine("|");
                Console.WriteLine("_____________");
            }
        }
        public void setBoard(int int1, int int2, string value){  
            board[int1, int2]=value;   
            Console.WriteLine("Move is complete.");              
        }
        public string[,] getBoard(){  
            return board;               
        }

        public string checkValue(int index1, int index2){
            return board[index1,index2];
        }
        

        
    
    }
}