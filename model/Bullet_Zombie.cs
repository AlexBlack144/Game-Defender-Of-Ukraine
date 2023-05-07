using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game_Kursak.model
{
    internal class Bullet_Zombie
    {
        public string diraction;
        public int bulletLeft;
        public int bulletTop;

        private int speed = 10;
        private PictureBox bullet_zombie = new PictureBox();
        private Timer bulletTimer = new Timer();

        public void MakeBullet(Form form)
        {
            bullet_zombie.BackColor = Color.White;
            bullet_zombie.Size = new Size(5, 5);
            bullet_zombie.Tag = "bullet_zombie";
            bullet_zombie.Left = bulletLeft;
            bullet_zombie.Top = bulletTop;
            bullet_zombie.BringToFront();

            form.Controls.Add(bullet_zombie);

            bulletTimer.Interval = speed;
            bulletTimer.Tick += new EventHandler(BulletTimerEvent);
            bulletTimer.Start();

        }

        private void BulletTimerEvent(object sender, EventArgs e)
        {
            if (diraction == "left")
            {
                bullet_zombie.Left -= speed;
            }
            if (diraction == "right")
            {
                bullet_zombie.Left += speed;
            }
            if (diraction == "up")
            {
                bullet_zombie.Top -= speed;
            }
            if (diraction == "down")
            {
                bullet_zombie.Top += speed;
            }

            if (bullet_zombie.Left < 10 || bullet_zombie.Left > 860 || bullet_zombie.Top < 10 || bullet_zombie.Top > 600)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet_zombie.Dispose();
                bulletTimer = null;
                bullet_zombie = null;
            }
        }
    }
}
