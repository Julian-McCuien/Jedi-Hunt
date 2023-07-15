using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Jedi_Hunt
{
    internal class Laser
    {
        public string direction;
        public int laserLeft;
        public int laserTop;

        private int speed = 20;
        private PictureBox laser = new PictureBox();
        private Timer laserTimer = new Timer();
        private bool canShoot = true;
        private int delayMilliseconds = 500;
        //List<Image> shootRightImages = new List<Image> { Properties.Resources._6, Properties.Resources._7 };
        //List<Image> shootLeftImages = new List<Image> { Properties.Resources._13, Properties.Resources._14 };
        

        public void makeLaser(Form form)
        {
            SoundPlayer soundplayer = new SoundPlayer("blaster.wav");
            soundplayer.Play();
            laser.BackColor = Color.Red;
            laser.Size = new Size(75, 5);
            laser.Tag = "laser";
            laser.Left = laserLeft;
            laser.Top = laserTop;
            laser.BringToFront();

            form.Controls.Add(laser);

            laserTimer.Interval = speed;
            laserTimer.Tick += new EventHandler(LaserTimerEvent);
            laserTimer.Start();
        }
        private void LaserTimerEvent(object sender, EventArgs e)
        {
            if (direction == "left")
            {
                laser.Left -= speed;
            }
            if (direction == "right")
            {
                laser.Left += speed;
            }
            if (direction == "up") 
            {
                laser.Top -= speed;
            }
            if (direction == "down")
            {
                laser.Top += speed;
            }
            if (laser.Left < 10 || laser.Left > 860 || laser.Top < 10 || laser.Top > 600)
            {
                laserTimer.Stop();
                laserTimer.Dispose();
                laser.Dispose();
                laserTimer = null;
                laser = null;

            }
        }


    }
}
