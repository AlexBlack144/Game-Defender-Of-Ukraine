using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game_Kursak.model
{
    internal class Bullet
    {
        public string diraction;
        public int bulletLeft;
        public int bulletTop;

        private int speed = 10;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();

        public void MakeBullet(Form form)
        {
            bullet.BackColor = Color.OrangeRed;
            bullet.Size = new Size(8, 8);
            bullet.Tag = "bullet";
            bullet.Left = bulletLeft;
            bullet.Top = bulletTop;
            bullet.BringToFront();

            form.Controls.Add(bullet);

            bulletTimer.Interval = speed;
            bulletTimer.Tick += new EventHandler(BulletTimerEvent);
            bulletTimer.Start();

        }

        private void BulletTimerEvent(object sender, EventArgs e)
        {
            if (diraction == "left")
            {
                bullet.Left -= speed;
            }
            if (diraction == "right")
            {
                bullet.Left += speed;
            }
            if (diraction == "up")
            {
                bullet.Top -= speed;
            }
            if (diraction == "down")
            {
                bullet.Top += speed;
            }

            if (bullet.Left < 10 || bullet.Left > 860 || bullet.Top < 10 || bullet.Top > 600)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null;
                bullet = null;
            }
        }

    }
}
