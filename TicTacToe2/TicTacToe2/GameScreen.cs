using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe2
{
    public partial class GameScreen : Form
    {
        public GameScreen()
        {
            InitializeComponent();

        }
        GameControl gameControl;
        private void GameButtons(object sender, EventArgs e)
        {
            gameControl.GamePosition(sender);
            WinnerNameLbl.Text = "Kazanan: " + gameControl.winnerNamelKontrol();
            if (gameControl.isClickFinish)
            {
                for (int i = 1; i <= 9; i++) 
                { string buttonName = "button" + i;
                 Button button = Controls.Find(buttonName, true).FirstOrDefault() as Button;
                 if (button != null) { button.Enabled = false; } 
                }
            }

        }


        private void button10_Click(object sender, EventArgs e)
        {
            GameScreen gameScreen = new GameScreen();
            gameScreen.ShowDialog();
            this.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            gameControl =new GameControl();
        }
    }
}
