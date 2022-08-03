namespace GameBoard{
    public class Board {
        public String[,] board;

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

        
    
    }
}