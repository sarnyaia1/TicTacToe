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

        //Alap változók definiálása
        String[] gameBoard = new string[9];
        int currentTurn = 0;
        int countWinX = 0;
        int countWin0 = 0;


        // Az X/0 szimbólumok számlálása
        public String drawSymbol(int turn) {
            if (turn % 2 == 0)
            {
                return "0";
            }
            else {
                return "X";
            }
        }


        // Mezők megnyomásának interakciói
        private void button1_Click(object sender, EventArgs e)
        {

            if (gameBoard[0] != "X" && gameBoard[0] != "0") //csak akkor változik a mező értéke, ha még üres
            {
                gameBoard[0] = drawSymbol(currentTurn);
                currentTurn++;
            }
            Color buttonColor = colorField(gameBoard[0]);
            button1.BackColor = buttonColor;    //mező beszinezése
            button1.Text = gameBoard[0];    //szimbólum megjelenítése
            checkWinner();  // Győztes ellenőrzés
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gameBoard[1] != "X" && gameBoard[1] != "0")
            {
                gameBoard[1] = drawSymbol(currentTurn);
                currentTurn++;
            }
            Color buttonColor = colorField(gameBoard[1]);
            button2.BackColor = buttonColor;
            button2.Text = gameBoard[1];
            checkWinner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gameBoard[2] != "X" && gameBoard[2] != "0")
            {
                gameBoard[2] = drawSymbol(currentTurn);
                currentTurn++;
            }
            Color buttonColor = colorField(gameBoard[2]);
            button3.BackColor = buttonColor;
            button3.Text = gameBoard[2];
            checkWinner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (gameBoard[3] != "X" && gameBoard[3] != "0")
            {
                gameBoard[3] = drawSymbol(currentTurn);
                currentTurn++;
            }
            Color buttonColor = colorField(gameBoard[3]);
            button4.BackColor = buttonColor;
            button4.Text = gameBoard[3];
            checkWinner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (gameBoard[4] != "X" && gameBoard[4] != "0")
            {
                gameBoard[4] = drawSymbol(currentTurn);
                currentTurn++;
            }
            Color buttonColor = colorField(gameBoard[4]);
            button5.BackColor = buttonColor;
            button5.Text = gameBoard[4];
            checkWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (gameBoard[5] != "X" && gameBoard[5] != "0")
            {
                gameBoard[5] = drawSymbol(currentTurn);
                currentTurn++;
            }
            Color buttonColor = colorField(gameBoard[5]);
            button6.BackColor = buttonColor;
            button6.Text = gameBoard[5];
            checkWinner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (gameBoard[6] != "X" && gameBoard[6] != "0")
            {
                gameBoard[6] = drawSymbol(currentTurn);
                currentTurn++;
            }
            Color buttonColor = colorField(gameBoard[6]);
            button7.BackColor = buttonColor;
            button7.Text = gameBoard[6];
            checkWinner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (gameBoard[7] != "X" && gameBoard[7] != "0")
            {
                gameBoard[7] = drawSymbol(currentTurn);
                currentTurn++;
            }
            Color buttonColor = colorField(gameBoard[7]);
            button8.BackColor = buttonColor;
            button8.Text = gameBoard[7];
            checkWinner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (gameBoard[8] != "X" && gameBoard[8] != "0")
            {
                gameBoard[8] = drawSymbol(currentTurn);
                currentTurn++;
            }
            Color buttonColor = colorField(gameBoard[8]);
            button9.BackColor = buttonColor;
            button9.Text = gameBoard[8];
            checkWinner();
        }

        //Mezők beszínezése kattintásra
        public System.Drawing.Color colorField(String symbol)
        {
            if (symbol.Equals("0"))
            {
                return System.Drawing.Color.LightBlue;
            }
            else if (symbol.Equals("X"))
            {
                return System.Drawing.Color.LightSalmon;
            }
            return System.Drawing.Color.White;
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

                if (counter == 9)
                {
                    resetMatch();
                    MessageBox.Show("DRAW!", "We don't have a winner!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }


        //Ellenőrizni, hogy van-e nyertes
        public void checkWinner()
        { 
            for(int i = 0; i < 8; i++)
            {
                //Győztes mezők
                int one = 0;
                int two = 0;
                int three = 0;
                String combination = "";

                switch (i) 
                {
                    case 0:
                        combination = gameBoard[0] + gameBoard[4] + gameBoard[8]; //kereszt1
                        one = 0;
                        two = 4;
                        three = 8;
                        break;
                    case 1:
                        combination = gameBoard[2] + gameBoard[4] + gameBoard[6]; //kereszt2
                        one = 2;
                        two = 4;
                        three = 6;
                        break;
                    case 2:
                        combination = gameBoard[0] + gameBoard[1] + gameBoard[2]; //vizszint1
                        one = 0;
                        two = 1;
                        three = 2;
                        break;
                    case 3:
                        combination = gameBoard[3] + gameBoard[4] + gameBoard[5]; //vizszint2
                        one = 3;
                        two = 4;
                        three = 5;
                        break;
                    case 4:
                        combination = gameBoard[6] + gameBoard[7] + gameBoard[8]; //vizszint3
                        one = 6;
                        two = 7;
                        three = 8;
                        break;
                    case 5:
                        combination = gameBoard[0] + gameBoard[3] + gameBoard[6]; //fuggoleges1
                        one = 0;
                        two = 3;
                        three = 6;
                        break;
                    case 6:
                        combination = gameBoard[1] + gameBoard[4] + gameBoard[7]; //fuggoleges2
                        one = 1;
                        two = 4;
                        three = 7;
                        break;
                    case 7:
                        combination = gameBoard[2] + gameBoard[5] + gameBoard[8]; //fuggoleges3
                        one = 2;
                        two = 5;
                        three = 8;
                        break;
                }

                if (combination.Equals("000"))
                {
                    winColor(one);
                    winColor(two);
                    winColor(three);
                    MessageBox.Show("0 has won the match!!", "We have a winner!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //Ha 10 győztes meccs megvan akkor megnyerte a fél a játékot, és az egész indul előről!
                    if (countWin0 < 10)
                    {
                        countWin0++;
                        displayScore0.Text = countWin0.ToString();
                        resetMatch();
                    }
                    else {
                        MessageBox.Show("X has won the WAR!!", "We have a winner!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        displayScoreX.Text = countWinX.ToString();
                        displayScore0.Text = countWin0.ToString();
                        resetMatch();
                    }
                } else if (combination.Equals("XXX"))
                {
                    winColor(one);
                    winColor(two);
                    winColor(three);
                    MessageBox.Show("X has won the match!!", "We have a winner!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (countWinX < 10)
                    {
                        countWinX++;
                        displayScoreX.Text = countWinX.ToString();
                        resetMatch();
                    }
                    else
                    {
                        MessageBox.Show("X has won the WAR!!", "We have a winner!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        displayScoreX.Text = countWinX.ToString();
                        displayScore0.Text = countWin0.ToString();
                        resetMatch();

                    }
                }

                checkDraw();
            }
        }

        //Győzelem esetén zöld mező kijelölés
        public void winColor(int number)
        {
            switch (number)
            {
                case 0:
                    button1.BackColor = System.Drawing.Color.Green;
                    break;
                case 1:
                    button2.BackColor = System.Drawing.Color.Green;
                    break;
                case 2:
                    button3.BackColor = System.Drawing.Color.Green;
                    break;
                case 3:
                    button4.BackColor = System.Drawing.Color.Green;
                    break;
                case 4:
                    button5.BackColor = System.Drawing.Color.Green;
                    break;
                case 5:
                    button6.BackColor = System.Drawing.Color.Green;
                    break;
                case 6:
                    button7.BackColor = System.Drawing.Color.Green;
                    break;
                case 7:
                    button8.BackColor = System.Drawing.Color.Green;
                    break;
                case 8:
                    button9.BackColor = System.Drawing.Color.Green;
                    break;

            }
        }


        //Meccs újrakezdése
        public void resetMatch() 
        {   
            // szimbólumok törlése
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            //színek törlése
            button1.BackColor = System.Drawing.Color.White;
            button2.BackColor = System.Drawing.Color.White;
            button3.BackColor = System.Drawing.Color.White;
            button4.BackColor = System.Drawing.Color.White;
            button5.BackColor = System.Drawing.Color.White;
            button6.BackColor = System.Drawing.Color.White;
            button7.BackColor = System.Drawing.Color.White;
            button8.BackColor = System.Drawing.Color.White;
            button9.BackColor = System.Drawing.Color.White;
            gameBoard = new string[9];
            currentTurn = 0;
        }


        // Teljes játék újraindítása
        public void fullReset() {
            resetMatch();
            countWinX = 0;
            countWin0 = 0;
            displayScoreX.Text = countWinX.ToString();
            displayScore0.Text = countWin0.ToString();
        }

        private void resetFields_Click(object sender, EventArgs e)
        {
            
            resetMatch(); 
        }

        
        private void resetGame_Click(object sender, EventArgs e)
        {
            fullReset();
        }

        private void TicTacToe(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void displayScoreX_Click(object sender, EventArgs e)
        {

        }

    }
}
