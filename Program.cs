using System;
using Logic;
/*
Game initializer class
*/

namespace Program{
    public class Program{

        public static void Main(string [] args){
            Console.WriteLine("Welcome to Tic-Tac-Toe game.You're gonna play with a computer.");
            Console.Write("Select the symbol to play X/O ?");
            Console.WriteLine();
           // string userSymbol = Console.ReadLine();
            var game = new Game("X");
        }
    }
}