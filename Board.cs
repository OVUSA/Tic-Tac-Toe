namespace GameBoard{
    public class Board {
        public String[,] board;

        public Board(){

            board = new String[,]{
                {" ", " ", " "},
                {" ", " ", " "},
                {"", " ", "  "}
            };
        }
    
    public void printBoard(){
        Console.WriteLine ("----------------");
        for( int i = 0;i< 3;i++){
            for ( int j = 0;j<3;j++){
                Console.Write("|");
                Console.WriteLine(board[i,j]);
                

            }
        }
        Console.WriteLine("|");
        Console.Write("---");

    }
        

    }
}