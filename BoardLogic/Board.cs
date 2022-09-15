using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLogic
{
    public class Board
    {
        public int[] Grid = new int[9];
        public int currentPlayer;
        public int emptyCells = 9;

        public Board()
        {

            for (int i = 0; i < 9; i++)
            {
                Grid[i] = 0;
            }
        }

        //TODO
        public int checkWinner()
        {
            if (Grid[0] == Grid[1] && Grid[1] == Grid[2] && Grid[1] != 0)
            {
                return Grid[0];
            }
            else
            {
                return 0;
            }

        }


        public void completeMove(int coordinate,int currentPlayer)          
        {
            Grid[coordinate] = currentPlayer;
        }

        public void computerMove()
        {
            Random randomMove = new Random();

        }

        public bool validateMove(int userInput)
        {
            if (Grid[userInput] == 0)
            {
                return true;
            }
            return false;
        }
    }


    
}
