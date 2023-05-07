using Game_Kursak.controller;
using System;
using System.Windows.Forms;
using Game_Kursak.view;
using Game_Kursak.model;
using System.Collections.Generic;

namespace Game_Kursak
{
    public partial class Form_Game : Form
    {
        FormAfterDeathPlayer formAfterDeathPlayer = new FormAfterDeathPlayer();
        FormMenu menuForm = new FormMenu();
        Controller view_model = new Controller();
        public List<SaveResult> list_result = new List<SaveResult>();
        const int HP = 100;

        int ammo_piced_up = 0;
        int fired_bullets = 0;
        int med_kit_picked_up = 0;

        int time_shoot_zombie = 0;

        int time_game_s = 0;
        int time_game_m = 0;
        int time_game_h = 0;

        public Form_Game()
        {
            InitializeComponent();
            view_model.RestartGame(player, this, GameTimer, TimeOfGameUser);
            
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            time_shoot_zombie++;

            if (view_model.player_class.playerHealth > 1)
            {
                healthBar.Value = (int)view_model.player_class.playerHealth;
            }
            else
            {
                view_model.player_class.gameOver = true;
                player.Image = Properties.Resources.dead;
                GameTimer.Stop();
                TimeOfGameUser.Stop();

                formAfterDeathPlayer.ShowDialog();
                if (formAfterDeathPlayer.Btn == "restart")
                {
                    view_model.RestartGame(player, this, GameTimer, TimeOfGameUser);
                    time_game_s = 0;
                    time_game_m = 0;
                    time_game_h = 0;
                }
                else if (formAfterDeathPlayer.Btn == "menu")
                {
                    this.Close();
                    menuForm.Show();
                }
                else if (formAfterDeathPlayer.Btn == "save")
                {
                    view_model.SaveResultPlayer(formAfterDeathPlayer.NickNameOfPlayer, view_model.player_class.score, 
                        ammo_piced_up, fired_bullets, med_kit_picked_up, med_kit_picked_up*30, txtTime.Text, list_result);
                    view_model.SaveToTxt(list_result);
                    this.Close();
                    menuForm.list_result_menu = list_result;
                    menuForm.Show();
                }
            }

            txtAmmo.Text = "Ammo: " + view_model.player_class.ammo;
            txtScore.Text = "Kills: " + view_model.player_class.score;
           

            if (view_model.player_class.goLeft == true && player.Left > 0)
            {
                player.Left -= view_model.player_class.speed;
            }
            if (view_model.player_class.goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += view_model.player_class.speed;
            }
            if (view_model.player_class.goUp == true && player.Top > 45)
            {
                player.Top -= view_model.player_class.speed;
            }
            if (view_model.player_class.goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += view_model.player_class.speed;
            }

            foreach (Control item in this.Controls)
            {
                if (item is PictureBox && (string)item.Tag == "ammo")
                {
                    if (player.Bounds.IntersectsWith(item.Bounds))
                    {
                        this.Controls.Remove(item);
                        ((PictureBox)item).Dispose();
                        view_model.player_class.ammo += 5;
                        ammo_piced_up++;
                    }
                }
                if (item is PictureBox && (string)item.Tag == "hp")
                {
                    if (time_game_s == 35 || time_game_s == 5)
                    {
                        this.Controls.Remove(item);
                        ((PictureBox)item).Dispose();
                    }
                    else
                    {
                        if (player.Bounds.IntersectsWith(item.Bounds))
                        {
                            this.Controls.Remove(item);
                            ((PictureBox)item).Dispose();
                            if (view_model.player_class.playerHealth < 100)
                            {
                                med_kit_picked_up++;
                                view_model.player_class.playerHealth += 30;
                                if (view_model.player_class.playerHealth > 100)
                                {
                                    view_model.player_class.playerHealth = 100;
                                }
                            }

                        }
                    }
                   
                }
                if (item is PictureBox && (string)item.Tag == "zombie")
                {
                    if (player.Bounds.IntersectsWith(item.Bounds))
                    {
                        view_model.player_class.playerHealth -= 1;
                    }

                    if (item.Left > player.Left)
                    {
                        item.Left -= view_model.zombieSpeed;
                        ((PictureBox)item).Image = Properties.Resources.zleft;
                    }
                    if (item.Left < player.Left)
                    {
                        item.Left += view_model.zombieSpeed;
                        ((PictureBox)item).Image = Properties.Resources.zright;
                    }
                    if (item.Top > player.Top)
                    {
                        item.Top -= view_model.zombieSpeed;
                        ((PictureBox)item).Image = Properties.Resources.zup;
                    }
                    if (item.Top < player.Top)
                    {
                        item.Top += view_model.zombieSpeed;
                        ((PictureBox)item).Image = Properties.Resources.zdown;
                    }

                }
                if (item is PictureBox && ((string)item.Tag == "shooter_left" || (string)item.Tag == "shooter_right"))
                {
                   if ((time_shoot_zombie % 20) == 0)
                    {
                        if ((string)item.Tag == "shooter_left")
                        {
                            view_model.ShootBulletZombie("left", (PictureBox)item, this);
                        }
                        if ((string)item.Tag == "shooter_right")
                        {
                            view_model.ShootBulletZombie("right", (PictureBox)item, this);
                        }
                    }
                    if (item.Top < player.Top)
                    {
                        item.Top += view_model.zombieSpeed;
                    }
                    if (item.Top > player.Top)
                    {
                        item.Top -= view_model.zombieSpeed;
                    }
                }
                if (item is PictureBox && ((string)item.Tag == "shooter_up" || (string)item.Tag == "shooter_down"))
                {
                    if ((time_shoot_zombie % 20) == 0)
                    {
                        if ((string)item.Tag == "shooter_up")
                        {
                            view_model.ShootBulletZombie("up", (PictureBox)item, this);
                        }
                        if ((string)item.Tag == "shooter_down")
                        {
                            view_model.ShootBulletZombie("down", (PictureBox)item, this);
                        }
                    }
                    if (item.Left < player.Left)
                    {
                        item.Left += view_model.zombieSpeed;
                    }
                    if (item.Left > player.Left)
                    {
                        item.Left -= view_model.zombieSpeed;
                    }
                }
                if (item is PictureBox && ((string)item.Tag == "shooters_left_right_up_down"))
                {
                    if (item.Top < player.Top)
                    {
                        item.Top += view_model.zombieSpeed;
                        ((PictureBox)item).Image = Properties.Resources.shooters_left_right_up_down;
                        if ((time_shoot_zombie % 20) == 0)
                        {
                            view_model.ShootBulletZombie("right", (PictureBox)item, this);
                        }
                    }
                    if (item.Top > player.Top)
                    {
                        item.Top -= view_model.zombieSpeed;
                        ((PictureBox)item).Image = Properties.Resources.shooters_left_right_up_down;
                        if ((time_shoot_zombie % 20) == 0)
                        {
                            view_model.ShootBulletZombie("left", (PictureBox)item, this);
                        }
                    }
                    if (item.Left < player.Left)
                    {
                        item.Left += view_model.zombieSpeed;
                        ((PictureBox)item).Image = Properties.Resources.shooters_left_right_up_down;
                        if ((time_shoot_zombie % 20) == 0)
                        {
                            view_model.ShootBulletZombie("down", (PictureBox)item, this);
                        }
                    }
                    if (item.Left > player.Left)
                    {
                        item.Left -= view_model.zombieSpeed;
                        ((PictureBox)item).Image = Properties.Resources.shooters_left_right_up_down;
                        if ((time_shoot_zombie % 20) == 0)
                        {
                            view_model.ShootBulletZombie("up", (PictureBox)item, this);
                        }
                    }
                }

                foreach (Control item_bullet in this.Controls)
                {
                    if (item_bullet is PictureBox && (string)item_bullet.Tag == "bullet" && item is PictureBox && (string)item.Tag == "zombie")
                    {
                        if (item.Bounds.IntersectsWith(item_bullet.Bounds))
                        {
                            view_model.player_class.score++;
                            this.Controls.Remove(item_bullet);
                            ((PictureBox)item_bullet).Dispose();
                            this.Controls.Remove(item);
                            ((PictureBox)item).Dispose();
                            view_model.zombiesList.Remove(((PictureBox)item));
                            view_model.MakeZombies(player, this);
                            if (view_model.player_class.score == 10)
                            {
                                view_model.MakeZombiesShooter(player,  this, Properties.Resources.shooter_left, "shooter_left");
                            }
                            if (view_model.player_class.score == 20)
                            {
                                view_model.MakeZombiesShooter(player, this, Properties.Resources.shooter_right, "shooter_right");
                            }
                            if (view_model.player_class.score == 30)
                            {
                                view_model.MakeZombiesShooter(player, this, Properties.Resources.shooter_up, "shooter_up");
                            }
                            if (view_model.player_class.score == 40)
                            {
                                view_model.MakeZombiesShooter(player, this, Properties.Resources.shooter_down, "shooter_down");
                            }
                            if (view_model.player_class.score == 50)
                            {
                                view_model.MakeZombiesShooter(player, this, Properties.Resources.shooters_left_right_up_down, "shooters_left_right_up_down");
                            }
                        }
                    }
                }

                foreach (Control item_bullet_zombie in this.Controls)
                {
                    if (item_bullet_zombie is PictureBox && (string)item_bullet_zombie.Tag == "bullet_zombie")
                    {
                        if (player.Bounds.IntersectsWith(item_bullet_zombie.Bounds))
                        {
                            this.Controls.Remove(item_bullet_zombie);
                            view_model.player_class.playerHealth -= 10;
                        }
                    }
                }

                foreach (Control item_shooter_left in this.Controls)
                {
                    if (item is PictureBox && (string)item.Tag == "bullet" && item_shooter_left is PictureBox && ((string)item_shooter_left.Tag == "shooter_left"))
                    {
                        if (item_shooter_left.Bounds.IntersectsWith(item.Bounds))
                        {
                            view_model.player_class.score++;
                            this.Controls.Remove(item);
                            ((PictureBox)item).Dispose();
                            this.Controls.Remove(item_shooter_left);
                            ((PictureBox)item_shooter_left).Dispose();
                            view_model.zombiesList.Remove(((PictureBox)item_shooter_left));
                            view_model.MakeZombiesShooter(player, this, Properties.Resources.shooter_left, "shooter_left");
                            if (view_model.player_class.score == 20)
                            {
                                view_model.MakeZombiesShooter(player, this, Properties.Resources.shooter_right, "shooter_right");
                            }
                            if (view_model.player_class.score == 30)
                            {
                                view_model.MakeZombiesShooter(player, this, Properties.Resources.shooter_up, "shooter_up");
                            }
                            if (view_model.player_class.score == 40)
                            {
                                view_model.MakeZombiesShooter(player, this, Properties.Resources.shooter_down, "shooter_down");
                            }
                            if (view_model.player_class.score == 50)
                            {
                                view_model.MakeZombiesShooter(player, this, Properties.Resources.shooters_left_right_up_down, "shooters_left_right_up_down");
                            }
                        }
                    }
                }
                foreach (Control item_shooter_right in this.Controls)
                {
                    if (item is PictureBox && (string)item.Tag == "bullet" && item_shooter_right is PictureBox && ((string)item_shooter_right.Tag == "shooter_right"))
                    {
                        if (item_shooter_right.Bounds.IntersectsWith(item.Bounds))
                        {
                            view_model.player_class.score++;
                            this.Controls.Remove(item);
                            ((PictureBox)item).Dispose();
                            this.Controls.Remove(item_shooter_right);
                            ((PictureBox)item_shooter_right).Dispose();
                            view_model.zombiesList.Remove(((PictureBox)item_shooter_right));
                            view_model.MakeZombiesShooter(player, this, Properties.Resources.shooter_right, "shooter_right");
                            if (view_model.player_class.score == 30)
                            {
                                view_model.MakeZombiesShooter(player, this, Properties.Resources.shooter_up, "shooter_up");
                            }
                            if (view_model.player_class.score == 40)
                            {
                                view_model.MakeZombiesShooter(player, this, Properties.Resources.shooter_down, "shooter_down");
                            }
                            if (view_model.player_class.score == 50)
                            {
                                view_model.MakeZombiesShooter(player, this, Properties.Resources.shooters_left_right_up_down, "shooters_left_right_up_down");
                            }
                        }
                    }
                }
                foreach (Control item_shooter_up in this.Controls)
                {
                    if (item is PictureBox && (string)item.Tag == "bullet" && item_shooter_up is PictureBox && ((string)item_shooter_up.Tag == "shooter_up"))
                    {
                        if (item_shooter_up.Bounds.IntersectsWith(item.Bounds))
                        {
                            view_model.player_class.score++;
                            this.Controls.Remove(item);
                            ((PictureBox)item).Dispose();
                            this.Controls.Remove(item_shooter_up);
                            ((PictureBox)item_shooter_up).Dispose();
                            view_model.zombiesList.Remove(((PictureBox)item_shooter_up));
                            view_model.MakeZombiesShooter(player, this, Properties.Resources.shooter_up, "shooter_up");
                            if (view_model.player_class.score == 40)
                            {
                                view_model.MakeZombiesShooter(player, this, Properties.Resources.shooter_down, "shooter_down");
                            }
                            if (view_model.player_class.score == 50)
                            {
                                view_model.MakeZombiesShooter(player, this, Properties.Resources.shooters_left_right_up_down, "shooters_left_right_up_down");
                            }
                        }
                    }
                }
                foreach (Control item_shooter_down in this.Controls)
                {
                    if (item is PictureBox && (string)item.Tag == "bullet" && item_shooter_down is PictureBox && ((string)item_shooter_down.Tag == "shooter_down"))
                    {
                        if (item_shooter_down.Bounds.IntersectsWith(item.Bounds))
                        {
                            view_model.player_class.score++;
                            this.Controls.Remove(item);
                            ((PictureBox)item).Dispose();
                            this.Controls.Remove(item_shooter_down);
                            ((PictureBox)item_shooter_down).Dispose();
                            view_model.zombiesList.Remove(((PictureBox)item_shooter_down));
                            view_model.MakeZombiesShooter(player, this, Properties.Resources.shooter_down, "shooter_down");
                            if (view_model.player_class.score == 50)
                            {
                                view_model.MakeZombiesShooter(player, this, Properties.Resources.shooters_left_right_up_down, "shooters_left_right_up_down");
                            }
                        }
                    }
                }
                foreach (Control item_shooter_shooters_left_right_up_down in this.Controls)
                {
                    if (item is PictureBox && (string)item.Tag == "bullet" && item_shooter_shooters_left_right_up_down is PictureBox && ((string)item_shooter_shooters_left_right_up_down.Tag == "shooters_left_right_up_down"))
                    {
                        if (item_shooter_shooters_left_right_up_down.Bounds.IntersectsWith(item.Bounds))
                        {
                            view_model.player_class.score++;
                            this.Controls.Remove(item);
                            ((PictureBox)item).Dispose();
                            this.Controls.Remove(item_shooter_shooters_left_right_up_down);
                            ((PictureBox)item_shooter_shooters_left_right_up_down).Dispose();
                            view_model.zombiesList.Remove(((PictureBox)item_shooter_shooters_left_right_up_down));
                            view_model.MakeZombiesShooter(player, this, Properties.Resources.shooters_left_right_up_down, "shooters_left_right_up_down");
                        }
                    }
                }

            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (view_model.player_class.gameOver == true)
            {
                return;
            }

            if (e.KeyCode == Keys.Left)
            {
                view_model.player_class.goLeft = true;
                view_model.player_class.facing = "left";
                player.Image = Properties.Resources.left;
            }

            if (e.KeyCode == Keys.Right)
            {
                view_model.player_class.goRight = true;
                view_model.player_class.facing = "right";
                player.Image = Properties.Resources.right;
            }
            if (e.KeyCode == Keys.Up)
            {
                view_model.player_class.goUp = true;
                view_model.player_class.facing = "up";
                player.Image = Properties.Resources.up;
            }

            if (e.KeyCode == Keys.Down)
            {
                view_model.player_class.goDown = true;
                view_model.player_class.facing = "down";
                player.Image = Properties.Resources.down;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                view_model.player_class.goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                view_model.player_class.goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                view_model.player_class.goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                view_model.player_class.goDown = false;
            }

            if (e.KeyCode == Keys.Space && view_model.player_class.ammo > 0 && view_model.player_class.gameOver == false)
            {
                view_model.player_class.ammo--;
                view_model.ShootBullet(view_model.player_class.facing, player, this);
                fired_bullets++;
                if (view_model.player_class.ammo < 1)
                {
                    view_model.DropAmmo(player, this);
                }
            }

            if (e.KeyCode == Keys.Enter && view_model.player_class.gameOver == true)
            {
                view_model.RestartGame(player, this, GameTimer, TimeOfGameUser);
                time_game_s = 0;
                time_game_m = 0;
                time_game_h = 0;
            }
        }

        private void Form_Deactivate(object sender, EventArgs e)
        {
           if (view_model.player_class.gameOver != true)
           {
                Application.Exit();
           }
            
        }

        private void TimeOfGame_Tick(object sender, EventArgs e)
        {
            time_game_s++;
            if (time_game_s == 30)
            {
                view_model.DropHP(player, this);
            }
            
            if (time_game_s == 60)
            {
                time_game_s = 0;
                time_game_m++;
                view_model.DropHP(player, this);
            }
            if (time_game_m == 60)
            {
                time_game_m = 0;
                time_game_h++;
            }
            if (time_game_s > 9)
            {
                txtTime.Text = "Time: 0" + time_game_h + ":0" + time_game_m + ":" + time_game_s;
            }
            else if (time_game_m>9)
            {
                txtTime.Text = "Time: 0" + time_game_h + ":" + time_game_m + ":0" + time_game_s;
            }
            else if (time_game_h > 9)
            {
                txtTime.Text = "Time: " + time_game_h + ":0" + time_game_m + ":0" + time_game_s;
            }
            else if (time_game_s > 9 && time_game_m > 9)
            {
                txtTime.Text = "Time: 0" + time_game_h + ":" + time_game_m + ":" + time_game_s;
            }
            else if (time_game_h > 9 && time_game_m > 9)
            {
                txtTime.Text = "Time: " + time_game_h + ":" + time_game_m + ":0" + time_game_s;
            }
            else if (time_game_s > 9 && time_game_m > 9 && time_game_h > 9)
            {
                txtTime.Text = "Time: " + time_game_h + ":" + time_game_m + ":" + time_game_s;
            }
            else
            {
                txtTime.Text = "Time: 0" + time_game_h + ":0" + time_game_m + ":0" + time_game_s;
            }
            
        }
    }
}
