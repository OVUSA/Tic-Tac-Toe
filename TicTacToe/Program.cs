﻿using System;
using BoardLogic;

namespace Program
{
    public class TicTacToe
    {
        static Board game = new Board();
        static  Boolean winner = true;
        public static int currentPlayer = 1;

        public static void Main(string[] args)
        {
            //fill up the board

           //printBoard();
           // Console.WriteLine("Plase enter a number from 0 to 8");
           // int userTurn = int.Parse(Console.ReadLine());
           //Console.WriteLine("Your input is: "+ userTurn);

            while (game.checkWinner() == 0)
            {
                printBoard();
                Console.WriteLine("Plase enter a number from 0 to 8");
                int userTurn = int.Parse(Console.ReadLine());
                if (game.validateMove(userTurn))
                {
                    game.completeMove(userTurn, currentPlayer);
                    switchPlayer();

                }
                else
                {
                    continue;
                }


            }



        }
        public static void switchPlayer()
        {
            if (currentPlayer == 1) { currentPlayer = 2; }
            else { currentPlayer = 1; }
        }

        // Player 1 == X ; Player 2 = O
        public static void printBoard()
        {
            for( int i = 0; i < game.Grid.Length; i++)
            {
                if (game.Grid[i] == 0)
                {
                    Console.Write(" . ");
                }else if (game.Grid[i] == 1)
                {
                    Console.Write(" X ");
                }else if (game.Grid[i] == 2)
                {
                    Console.Write(" O ");
                }

                if(i==2 || i == 5)
                {
                    Console.WriteLine();

                }
            }
        }

    }
}