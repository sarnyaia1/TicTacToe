using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] gameBoard = new string[9];
        int currentTurn = 0;


        //Táblázatban megjeleníteni X/0 jelet...
        public String returnSymbol(int turn) {
            if (turn % 2 == 0)
            {
                return "0";
            }
            else {
                return "X";
            }
        }

        //Ellenőrizni, hogy van-e nyertes
        public void checkWinner()
        { 
            for(int i = 0; i < 8; i++)
            {
                String combination = "";

                switch (i) 
                {
                    case 0:
                        combination = gameBoard[0] + gameBoard[4] + gameBoard[8]; //kereszt1
                        break;
                    case 1:
                        combination = gameBoard[2] + gameBoard[4] + gameBoard[6]; //kereszt2
                        break;
                    case 2:
                        combination = gameBoard[0] + gameBoard[1] + gameBoard[2]; //vizszint1
                        break;
                    case 3:
                        combination = gameBoard[3] + gameBoard[4] + gameBoard[5]; //vizszint2
                        break;
                    case 4:
                        combination = gameBoard[6] + gameBoard[7] + gameBoard[8]; //vizszint3
                        break;
                    case 5:
                        combination = gameBoard[0] + gameBoard[3] + gameBoard[6]; //fuggoleges1
                        break;
                    case 6:
                        combination = gameBoard[1] + gameBoard[4] + gameBoard[7]; //fuggoleges2
                        break;
                    case 7:
                        combination = gameBoard[2] + gameBoard[5] + gameBoard[8]; //fuggoleges3
                        break;
                }

                if (combination.Equals("000"))
                {
                    resetGame();
                    MessageBox.Show("0 has won the game!!", "We have a winner!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } else if (combination.Equals("XXX"))
                {
                    resetGame();
                    MessageBox.Show("X has won the game!!", "We have a winner!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                checkDraw();
            }
        }

        //Döntetlen esetén visszajelzés és újraindítás...
        public void checkDraw() 
        {
            int counter = 0;
            for (int i = 0; i < gameBoard.Length; i++) 
            {
                if (gameBoard[i] != null) 
                {
                    counter++;
                }

                if(counter == 9)
                {
                    resetGame();
                    MessageBox.Show("DRAW!", "We don't have a winner!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            
            }
        }


        //Játék újraindítása...
        public void resetGame() 
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            gameBoard = new string[9];
            currentTurn = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[0] = returnSymbol(currentTurn);
            button1.Text = gameBoard[0];
            checkWinner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[1] = returnSymbol(currentTurn);
            button2.Text = gameBoard[1];
            checkWinner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[2] = returnSymbol(currentTurn);
            button3.Text = gameBoard[2];
            checkWinner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[3] = returnSymbol(currentTurn);
            button4.Text = gameBoard[3];
            checkWinner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[4] = returnSymbol(currentTurn);
            button5.Text = gameBoard[4];
            checkWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[5] = returnSymbol(currentTurn);
            button6.Text = gameBoard[5];
            checkWinner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[6] = returnSymbol(currentTurn);
            button7.Text = gameBoard[6];
            checkWinner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[7] = returnSymbol(currentTurn);
            button8.Text = gameBoard[7];
            checkWinner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[8] = returnSymbol(currentTurn);
            button9.Text = gameBoard[8];
            checkWinner();
        }
    }
}
