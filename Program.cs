using System;
using Logic;
using GameBoard;

namespace Program{
    public class Program{

        public static void Main(string [] args){
            var game = new Game();
            game.players();
            var board = new Board();
            board.printBoard();


        }
    }
}