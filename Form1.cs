using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jedi_Hunt
{
    public partial class Form1 : Form
    {
        bool goLeft,goRight,goUp,goDown,gameOver;
        string facing = "down";
        int playerHealth = 100;
        int speed = 10;
        int lightSabers = 0;
        int enemeySpeed = 3;
        int score;
        private int animationFrame = 0;
        Random randomNumber = new Random();
        List<PictureBox> enemeyList = new List<PictureBox>();
        List<PictureBox> up = new List<PictureBox>();
        List<PictureBox> down = new List<PictureBox>();
        List<PictureBox> left = new List<PictureBox>();
        List<PictureBox> right = new List<PictureBox>();

        List<Image> upImages = new List<Image> { Properties.Resources._20, Properties.Resources._21, Properties.Resources._22, Properties.Resources._23 };
        List<Image> downImages = new List<Image> { Properties.Resources._15, Properties.Resources._16, Properties.Resources._17, Properties.Resources._18 };
        List<Image> leftImages = new List<Image> { Properties.Resources._8, Properties.Resources._9, Properties.Resources._10, Properties.Resources._11 };
        List<Image> rightImages = new List<Image> { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4 };

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timerAnimation.Interval = 100;
            timerAnimation.Enabled = true;
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
                healthBar.Value = playerHealth;
            }
            else
            {
                gameOver = true;
            }
            txtLightSabers.Text = "Light Sabers:" + lightSabers;
            txtScore.Text = "Score:" + score;

            if(goLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }
            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }
            if (goUp == true && player.Top > 55)
            {
                player.Top -= speed;
            }
            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = leftImages[animationFrame];
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true; 
                facing = "right"; 
                player.Image = rightImages[animationFrame];
            }
            if (e.KeyCode == Keys.Up)
            {
                facing = "up"; 
                goUp = true; 
                player.Image = upImages[animationFrame]; ; 
            }
            if (e.KeyCode == Keys.Down)
            {
                facing = "down";
                goDown = true; 
                player.Image = downImages[animationFrame]; 
            }
            if (e.KeyCode == Keys.Space)
            {
                ShootLaser(facing);
            }
            
        }

        private void timerAnimation_Tick_1(object sender, EventArgs e)
        {
            // Increment the animation frame
            animationFrame++;
            if (animationFrame >= upImages.Count) // after 4th image cycle back to first image
                animationFrame = 0;
            // Update the player's image based on the direction and animation frame
            switch (facing)
            {
                case "up":
                    player.Image = upImages[animationFrame];
                    break;
                case "down":
                    player.Image = downImages[animationFrame];
                    break;
                case "left":
                    player.Image = leftImages[animationFrame];
                    break;
                case "right":
                    player.Image = rightImages[animationFrame];
                    break;
            }
        }



        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (gameOver) return; // if game is over then do nothing in this event
           
            if (e.KeyCode == Keys.Left)
            {
               
                goLeft = false;
                player.Image = Properties.Resources._12;
            }
           
            if (e.KeyCode == Keys.Right)
            {
                
                goRight = false;
                player.Image = Properties.Resources._5;
            }
            
            if (e.KeyCode == Keys.Up)
            {
                
                goUp = false;
                player.Image = Properties.Resources._24;
            }
           
            if (e.KeyCode == Keys.Down)
            {
                
                goDown = false;
                player.Image = Properties.Resources._19;
            }
        }
        private void ShootLaser(string direction)
        {
            Laser shootLaser = new Laser();
            shootLaser.direction = direction;
            shootLaser.laserLeft = player.Left +(player.Width / 2);
            shootLaser.laserTop = player.Top +(player.Height / 2);
            shootLaser.makeLaser(this);
        }
        private void SpawnEnimies()
        {

        }
        private void RestartGame()
        {

        }
    }
}
