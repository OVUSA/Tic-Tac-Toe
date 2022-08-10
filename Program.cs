using System;
using Logic;
/*
Game initializer class
*/

namespace Program{
    public class Program{

        public static void Main(string [] args){
            Console.WriteLine("Welcome to Tic-Tac-Toe game.You're gonna play with a computer"+
            "You can choose level of difficulty 'e/d' which is easy/difficult.");
            string difficultyLevel = Console.ReadLine();

            Console.Write("Select a symbol to play with :  X/O ?");
            Console.WriteLine();
            string userSymbol = Console.ReadLine();
            var game = new Game(userSymbol,difficultyLevel);
        }
    }
}