using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe2
{
    internal class GameControl
    {
        string[,] game;
        public GameControl()
        {
            game = new string[3, 3];

        }
        string winnerName = "";
       public bool isClickFinish=false;
        string currentPlayer = "X";

        public string changePlayer()
        {
            if (currentPlayer == "X")
            {
                currentPlayer = "O";
            }
            else if (currentPlayer == "O")
            {
                currentPlayer = "X";
            }
            return currentPlayer;
        }
        public void DrawGame(string index, string playerName)
        {
            if (index == "button1") { game[0, 0] = playerName; }
            else if (index == "button2") { game[0, 1] = playerName; }
            else if (index == "button3") { game[0, 2] = playerName; }
            else if (index == "button4") { game[1, 0] = playerName; }
            else if (index == "button5") { game[1, 1] = playerName; }
            else if (index == "button6") { game[1, 2] = playerName; }
            else if (index == "button7") { game[2, 0] = playerName; }
            else if ((index == "button8")) { game[2, 1] = playerName; }
            else if (index == "button9") { game[2, 2] = playerName; }

        }
        public bool checkWinner()
        {
            bool kontrol = false;

            for (int i = 0; i < 3; i++)
            {
                if (game[i, 0] == game[i, 1] && game[i, 1] == game[i, 2] && game[i, 0] != null)
                {
                    kontrol = true;
                }

            }
            for (int j = 0; j < 3; j++)
            {
                if (game[0, j] == game[1, j] && game[1, j] == game[2, j] && game[0, j] != null)
                {
                    kontrol = true;
                }
            }
            if ((game[0, 0] == game[1, 1] && game[1, 1] == game[2, 2] && game[0, 0] != null) || (game[0, 2] == game[1, 1] && game[1, 1] == game[2, 0] && game[0, 2] != null))
            {
                kontrol = true;
            }

            if (kontrol)
            {
                return true;
            }
            else { return false; }
        }
        public string winnerNamelKontrol()
        {
            return winnerName;
        }
        public void GamePosition(object sender)
        {
            Button button = sender as Button;
            button.Enabled = false;
            button.Text = currentPlayer;
            DrawGame(button.Name, currentPlayer);

            if (currentPlayer == "X")
            {
                button.BackColor = Color.Blue;
            }
            else if (currentPlayer == "O")
            {
                button.BackColor = Color.Red;
            }
            if (checkWinner())
            {
                winnerName = currentPlayer;
                isClickFinish = true;
            }
            else
            {
                changePlayer();
            }
        }
    }
}
