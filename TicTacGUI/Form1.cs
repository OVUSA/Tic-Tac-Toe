using System;
using System.Windows.Forms;
using BoardLogic;

namespace TicTacGUI
{
    public partial class Form1 : Form
    { 
        public Board game = new Board();
        Button[] buttons  = new Button[9];
    
        public Form1()
        {
            InitializeComponent();
            game = new Board();
            // assigne buttons to an array
            buttons[0] = button1;
            buttons[1] = button2;
            buttons[2] = button3;
            buttons[3] = button4;
            buttons[4] = button5;
            buttons[5] = button6;
            buttons[6] = button7;
            buttons[7] = button8;
            buttons[8] = button9;
           
            //add functionallity to each button
            for ( int i = 0; i < 9; i++)
            {
                buttons[i].Click += handleButtonClick;
                buttons[i].Tag = i;
            }
        }

        // takes only user input
        private void handleButtonClick(object sender, EventArgs e)
        {
            Button clikedButton = (Button)sender;

           // MessageBox.Show("button " + clikedButton.Tag + "was cliked");

            // assigned a value to selected by user button
            int userPlayer = (int)clikedButton.Tag;
            game.Grid[userPlayer] = 1;
            updateBoard();
            computerTurn();
        }

        private void computerTurn()
        {
            int computerChoice = -1;

            while(computerChoice!=-1 || game.validateMove(computerChoice)==true)
            //create a while loop with rendom choice
        }

        // connect grid values and buttons text
        public void updateBoard()
        {
            for ( int i = 0;i< 9; i++)
            {
                if (game.Grid[i] == 0)
                {
                    buttons[i].Text = "";
                }else if (game.Grid[i] == 1)
                {
                    buttons[i].Text = "X";
                }else if (game.Grid[i] == 2)
                {
                    buttons[i].Text = "O";
                }
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            updateBoard();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            //updateBoard();
        }
    }
}
