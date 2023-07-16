using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Jedi_Hunt
{
    public partial class game : Form
    {
        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "down";
        int playerHealth = 100;
        int speed = 10;
        int lightSabers = 0;
        int jediSpeed = 3;
        int score;
        private int animationFrame = 0;
        string lastCollectedItemName;
        Random randomNumber = new Random();
        List<PictureBox> jediList = new List<PictureBox>();

        List<string> itemLocations = new List<string>();
        LinkedList<Items> items_list = new LinkedList<Items>();
        LinkedList<Items> playerItems = new LinkedList<Items>();
        int spawnTimeLimit = 50;
        int timeCounter = 0;
        Random random = new Random();
        string[] itemNames = new string[] { "boba head", "chewbacca head", "dl-44", "jabba the hutt", "r2d2", "luke skywalker", "qui-gon jinn lightsaber", "darth maul head", "princess leia", "han solo", "jango fett", "princess leia lightsaber", "lando calrissian", "mace windu lightsaber", "darth sidious", "anakin skywalker", "chewbacca", "scout trooper", "obi wan kenobi lightsaber", "darth dader", "darth vader lightsaber" };


        //player animation images
        List<Image> upImages = new List<Image> { Properties.Resources._20, Properties.Resources._21, Properties.Resources._22, Properties.Resources._23 };
        List<Image> downImages = new List<Image> { Properties.Resources._15, Properties.Resources._16, Properties.Resources._17, Properties.Resources._18 };
        List<Image> leftImages = new List<Image> { Properties.Resources._8, Properties.Resources._9, Properties.Resources._10, Properties.Resources._11 };
        List<Image> rightImages = new List<Image> { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4 };
        // shooting animation images
        List<Image> shootRightImages = new List<Image> { Properties.Resources._6, Properties.Resources._7 };
        List<Image> shootLeftImages = new List<Image> { Properties.Resources._13, Properties.Resources._14 };
        // luke skywalker animation images 
        List<Image> jediUpImages = new List<Image> { Properties.Resources.luke_u1, Properties.Resources.luke_u2, Properties.Resources.luke_u3, Properties.Resources.luke_u4 };
        List<Image> jediDownImages = new List<Image> { Properties.Resources.luke_d1, Properties.Resources.luke_d2, Properties.Resources.luke_d3, Properties.Resources.luke_d4 };
        List<Image> jediLeftImages = new List<Image> { Properties.Resources.luke_l1, Properties.Resources.luke_l2, Properties.Resources.luke_l3, Properties.Resources.luke_l4 };
        List<Image> jediRightImages = new List<Image> { Properties.Resources.luke_r1, Properties.Resources.luke_r2, Properties.Resources.luke_r3, Properties.Resources.luke_r4 };

        public game()
        {
            InitializeComponent();
            RestartGame();
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
                GameTimer.Stop();
                GameSummary gameSummary = new GameSummary(playerItems);
                gameSummary.Show();
                this.Hide();
            }
            txtLightSabers.Text = "Light Sabers:" + lightSabers;
            txtScore.Text = "Score:" + score;

            if (goLeft == true && player.Left > 0)
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
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "item")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();

                        // Find the corresponding item in the items_list
                        var item = items_list.FirstOrDefault(i => i.item_image == ((PictureBox)x).Image);
                        if (item != null)
                        {
                            playerItems.AddLast(item);
                            items_list.Remove(item);
                            lastCollectedItemName = item.name;
                            lblCollected.Text = lastCollectedItemName;
                            lblCollected.AutoSize = true;
                        }
                    }
                }
            }


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "lightsaber")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        lightSabers += 1;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "jedi")
                {
                    if (x.Left > player.Left)
                    {
                        x.Left -= jediSpeed;
                        ((PictureBox)x).Image = jediLeftImages[animationFrame % jediLeftImages.Count];
                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += jediSpeed;
                        ((PictureBox)x).Image = jediRightImages[animationFrame % jediLeftImages.Count];
                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= jediSpeed;
                        ((PictureBox)x).Image = jediDownImages[animationFrame % jediLeftImages.Count];
                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += jediSpeed;
                        ((PictureBox)x).Image = jediUpImages[animationFrame % jediLeftImages.Count];
                    }


                }
                if((x is PictureBox && (string)x.Tag == "jedi"))
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                    }
                }

                foreach (Control j in this.Controls)
                {

                    if ((j is PictureBox && (string)j.Tag == "laser") && (x is PictureBox && (string)x.Tag == "jedi"))
                    {

                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;
                            int jediCenterX = x.Left + x.Width / 2;
                            int jediCenterY = x.Top + x.Height / 2;
                            DropLightsaberAtLocation(jediCenterX, jediCenterY);
                            this.Controls.Remove(j);
                            j.Dispose();
                            this.Controls.Remove(x);
                            x.Dispose();
                            SpawnJedi();
                        }




                    }
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(gameOver == true)
            {
                return;
            }

            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                timerAnimation.Enabled = true;
                player.Image = leftImages[animationFrame];
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                timerAnimation.Enabled = true;
                player.Image = rightImages[animationFrame];
            }
            if (e.KeyCode == Keys.Up)
            {
                facing = "up";
                goUp = true;
                timerAnimation.Enabled = true;
                player.Image = upImages[animationFrame]; ;
            }
            if (e.KeyCode == Keys.Down)
            {
                facing = "down";
                goDown = true;
                timerAnimation.Enabled = true;
                player.Image = downImages[animationFrame];
            }
            if (e.KeyCode == Keys.Space)
            {
                ShootLaser(facing);
            }

        }

        private void timerAnimation_Tick_1(object sender, EventArgs e)
        {
            if (timeCounter == spawnTimeLimit)
            {
                DropItem();
                timeCounter = 0;
            }

            timeCounter++;
            animationFrame++;
            if (animationFrame >= upImages.Count) 
                animationFrame = 0;
            
            switch (facing)
            {

                case "shootLeft":
                    player.Image = shootLeftImages[animationFrame];
                    break;
                case "shootRight":
                    player.Image = shootRightImages[animationFrame];
                    break;
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
            if (gameOver) return; 

            if (e.KeyCode == Keys.Left)
            {

                goLeft = false;

            }

            if (e.KeyCode == Keys.Right)
            {

                goRight = false;

            }

            if (e.KeyCode == Keys.Up)
            {

                goUp = false;

            }

            if (e.KeyCode == Keys.Down)
            {

                goDown = false;

            }
            if (e.KeyCode == Keys.Space)
            {
                ShootLaser(facing);
            }
            if (!goLeft && !goRight && !goUp && !goDown)
            {
                
                switch (facing)
                {
                    case "up":

                        player.Image = Properties.Resources._24;
                        break;
                    case "down":
                        player.Image = Properties.Resources._19;
                        break;
                    case "left":
                        player.Image = Properties.Resources._12;
                        break;
                    case "right":
                        player.Image = Properties.Resources._5;
                        break;
                    default: break;
                }
                timerAnimation.Enabled = false;
            }
            else
            {
                timerAnimation.Enabled = true;
            }

        }
        private void ShootLaser(string direction)
        {
            if (direction == "right" || direction == "left")
            {
                int shootAnimationFrame = animationFrame % 2;

                if (direction == "right")
                {
                    player.Image = shootRightImages[shootAnimationFrame];
                }
                else if (direction == "left")
                {
                    player.Image = shootLeftImages[shootAnimationFrame];
                }
                Laser shootLaser = new Laser();
                shootLaser.direction = direction;
                shootLaser.laserLeft = player.Left + (player.Width / 2);
                shootLaser.laserTop = player.Top + (player.Height / 2);
                shootLaser.makeLaser(this);

            }

        }
        private void SpawnJedi()
        {
            PictureBox jedi = new PictureBox();
            jedi.Tag = "jedi";
            jedi.Image = Properties.Resources.luke_r4;
            jedi.BackColor = Color.Transparent;
            jedi.Left = randomNumber.Next(0, 900);
            jedi.Top = randomNumber.Next(0, 800);
            jedi.SizeMode = PictureBoxSizeMode.AutoSize;
            jediList.Add(jedi);
            this.Controls.Add(jedi);
            player.BringToFront();

        }
        private void DropItem()
        {
            int i = random.Next(0, itemLocations.Count);
            Items newItem = new Items();
            newItem.item_image = Image.FromFile(itemLocations[i]);
            newItem.name = itemNames[i];
            //BackColor = Color.Transparent;
            timeCounter = spawnTimeLimit;
            items_list.AddLast(newItem);
            PictureBox itemPictureBox = new PictureBox();
            itemPictureBox.Image = newItem.item_image;
            itemPictureBox.BackColor = Color.Transparent;
            itemPictureBox.Width = newItem.item_image.Width / 2;
            itemPictureBox.Height = newItem.item_image.Height / 2;
            itemPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            itemPictureBox.Left = randomNumber.Next(0, this.ClientSize.Width - itemPictureBox.Width);
            itemPictureBox.Top = randomNumber.Next(0, this.ClientSize.Height - itemPictureBox.Height);
            itemPictureBox.Tag = "item";
            this.Controls.Add(itemPictureBox);
            itemPictureBox.BringToFront();
            playerItems.AddLast(newItem);


        }

        private void game_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DropLightsaberAtLocation(int left, int top)
        {
            PictureBox lightsaber = new PictureBox();
            lightsaber.Image = Properties.Resources.lukelightsaber;
            lightsaber.BackColor = Color.Transparent;
            lightsaber.SizeMode = PictureBoxSizeMode.StretchImage;
            lightsaber.Width = 15;
            lightsaber.Height = 40;
            lightsaber.Left = left - (lightsaber.Width / 2);
            lightsaber.Top = top - (lightsaber.Height / 2);
            lightsaber.Tag = "lightsaber";
            this.Controls.Add(lightsaber);
            lightsaber.BringToFront();
            player.BringToFront();
        }
        private void RestartGame()
        {
            player.Image = Properties.Resources._14;

            foreach (PictureBox i in jediList)
            {
                this.Controls.Remove(i);
            }
            jediList.Clear();

            for (int i = 0; i < 1; i++)
            {
                SpawnJedi();
            }

            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;

            playerHealth = 100;
            score = 0;
            lightSabers = 0;

            GameTimer.Start();

            itemLocations = Directory.GetFiles("items", "*.png").ToList();


        }

    }
}
