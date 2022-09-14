using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            buttons[0] = button1;
            buttons[1] = button2;
            buttons[2] = button3;
            buttons[3] = button4;
            buttons[4] = button5;
            buttons[5] = button6;
            buttons[6] = button7;
            buttons[7] = button8;
            buttons[8] = button9;
           
            for ( int i = 0; i < 9; i++)
            {
                buttons[i].Click += handleButtonClick;
            }
        }

        private void handleButtonClick(object sender, EventArgs e)
        {
            Button clikedButton = (Button)sender;
            if(game.currentPlayer == 1) { clikedButton.Text = "X"; }
        }

        public void updateBoard()
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
