using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jedi_Hunt
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            tmrTieFighter.Start();
        }

        private void border(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Yellow);
            g.DrawRectangle(myPen, 210f, 70f, 470, 120);
        }

        private void tmrTieFighter_Tick(object sender, EventArgs e)
        {
            picTieFighter.Left += 3;
           
            if (picTieFighter.Left > 900)
            {
                picTieFighter.Left = -10;
            }
           
           
            
            
        }

        private void btnNewGame_MouseHover(object sender, EventArgs e)
        {
            btnNewGame.ForeColor = Color.Yellow;
            
            
        }

        private void btnoptions_MouseHover(object sender, EventArgs e)
        {
            btnoptions.ForeColor = Color.Yellow;
        }

        private void btnCredits_MouseHover(object sender, EventArgs e)
        {
            btnCredits.ForeColor = Color.Yellow;
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Yellow;
        }

        private void btnLoadGame_MouseHover(object sender, EventArgs e)
        {
            btnLoadGame.ForeColor = Color.Yellow;
        }

        private void btnNewGame_MouseLeave(object sender, EventArgs e)
        {
            btnNewGame.ForeColor = Color.Aqua;
        }

        private void btnLoadGame_MouseLeave(object sender, EventArgs e)
        {
            btnLoadGame.ForeColor = Color.Aqua;
        }

        private void btnoptions_MouseLeave(object sender, EventArgs e)
        {
            btnoptions.ForeColor = Color.Aqua;
        }

        private void btnCredits_MouseLeave(object sender, EventArgs e)
        {
            btnCredits.ForeColor = Color.Aqua;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Aqua;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            game gameForm = new game();
            gameForm.Show();
            this.Hide();
        }

        private void btnoptions_Click(object sender, EventArgs e)
        {
            Options optionPage = new Options();
            optionPage.ShowDialog();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            creditpage credits = new creditpage();
            credits.ShowDialog();
            this.Hide();
        }
    }
}
