using Game_Kursak.model;
using Newtonsoft.Json;
using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Formatting = Newtonsoft.Json.Formatting;

namespace Game_Kursak.controller
{
    internal class Controller
    {
        public SimpleTcpClient client;
        public Client client_parametrs = new Client();
        public Player player_class = new Player("up", 100, 10, 10);
        public int zombieSpeed = 3;
        public Random randNum = new Random();
        public List<PictureBox> zombiesList = new List<PictureBox>();
        public List<PictureBox> ammo_and_health = new List<PictureBox>();
        public Player z = new Player("up", 100, 10, 10);



        public void ShootBullet(string direction,PictureBox player, Form main)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.diraction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 5);
            shootBullet.MakeBullet(main);
        }

        public void ShootBulletZombie(string direction, PictureBox zombie, Form main)
        {
            Bullet_Zombie shootBulletZombie = new Bullet_Zombie();
            shootBulletZombie.diraction = direction;
            shootBulletZombie.bulletLeft = zombie.Left + (zombie.Width / 2);
            shootBulletZombie.bulletTop = zombie.Top + (zombie.Height / 2);
            shootBulletZombie.MakeBullet(main);
        }

        public void MakeZombies(PictureBox player, Form main)
        {
            PictureBox zombie = new PictureBox();
            zombie.BackColor = Color.FromArgb(0,0,0,0);
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Left = randNum.Next(0, 900);
            zombie.Top = randNum.Next(0, 800);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombiesList.Add(zombie);
            main.Controls.Add(zombie);
            player.BringToFront();
        }

        public void MakeZombiesShooter(PictureBox player, Form main, Bitmap facingResorce, string tag)
        {
            PictureBox zombie_shooter = new PictureBox();
            zombie_shooter.BackColor = Color.FromArgb(0, 0, 0, 0);
            zombie_shooter.Tag = tag;
            zombie_shooter.Image = facingResorce;
            zombie_shooter.Left = randNum.Next(0, 800);
            zombie_shooter.Top = randNum.Next(0, 600);
            zombie_shooter.SizeMode = PictureBoxSizeMode.AutoSize;
            zombiesList.Add(zombie_shooter);
            main.Controls.Add(zombie_shooter);
            player.BringToFront();
      
                
        }

        public void DropAmmo(PictureBox player, Form main)
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(10, main.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(60, main.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            main.Controls.Add(ammo);
            ammo_and_health.Add(ammo);
            ammo.BringToFront();
            player.BringToFront();
        }

        public void DropHP(PictureBox player, Form main)
        {
            PictureBox helth = new PictureBox();
            helth.Image = Properties.Resources.hp_Image;
            helth.SizeMode = PictureBoxSizeMode.AutoSize;
            helth.Left = randNum.Next(10, main.ClientSize.Width - helth.Width);
            helth.Top = randNum.Next(60, main.ClientSize.Height - helth.Height);
            helth.Tag = "hp";
            main.Controls.Add(helth);
            ammo_and_health.Add(helth);
            helth.BringToFront();
            player.BringToFront();
        }

        public void RestartGame(PictureBox player, Form main, Timer GameTimer, Timer TimeOfGame)
        {
            player.Image = Properties.Resources.up;
            
            foreach (PictureBox item in zombiesList)
            {
                main.Controls.Remove(item);
            }
            zombiesList.Clear();

            foreach (PictureBox item in ammo_and_health)
            {
                main.Controls.Remove(item);
            }
            ammo_and_health.Clear();

            for (int i = 0; i < 2; i++)
            {
                MakeZombies(player, main);
            }

            player_class.goUp = false;
            player_class.goDown = false;
            player_class.goLeft = false;
            player_class.goRight = false;
            player_class.gameOver = false;

            player_class.playerHealth = 100;
            player_class.score = 0;
            player_class.ammo = 10;

            GameTimer.Start();
            TimeOfGame.Start();
        }



        public void SaveResultPlayer(string nickName, int kills, int ammo_picked_up, int fired_bullets, int med_kit_picked_up, int hP_replenishment_amount, string game_time, List<SaveResult> results)
        {
            SaveResult saveResult = new SaveResult(nickName, kills, ammo_picked_up, fired_bullets, med_kit_picked_up, hP_replenishment_amount, game_time);
            results.Add(saveResult);
        }

        public void SaveToTxt(List<SaveResult> results)
        {
            string path = @"MyResults1.json";
            //string path = $@"C:\Users\Alex\source\repos\Omlet144\Game_Kursak\bin\Debug\MyResults1.json";
            string json = null;
            bool flag = true;

            try
            {
                string[] readText = File.ReadAllLines(path);
                foreach (string str in readText)
                {
                    json += str;
                }


                List<SaveResult>  list_result_statistics = JsonConvert.DeserializeObject<List<SaveResult>>(json);

                foreach (var item in list_result_statistics)
                {
                    if (item.client_NickName == results[0].client_NickName)
                    {
                        if (item.client_Kills < results[0].client_Kills)
                        {
                            item.client_Kills = results[0].client_Kills;
                            item.client_Ammo_picked_up = results[0].client_Ammo_picked_up;
                            item.client_Fired_bullets = results[0].client_Fired_bullets;
                            item.client_Med_kit_picked_up = results[0].client_Med_kit_picked_up;
                            item.client_HP_replenishment_amount = results[0].client_HP_replenishment_amount;
                            item.client_Game_time = results[0].client_Game_time;
                        }
                        flag = false;
                        break;
                    }
                }
                if (flag == true)
                {
                    var resQuery = results.Union(list_result_statistics);
                    json = JsonConvert.SerializeObject(resQuery, Formatting.Indented);
                }
                else
                {
                    json = JsonConvert.SerializeObject(list_result_statistics);
                }

                // Create the file, or overwrite if the file exists.
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(json);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                json = JsonConvert.SerializeObject(results, Formatting.Indented);
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(json);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
            }
        }

        public void OpenFromTxtLocalResults(List<SaveResult> list_result_statistics, DataGridView dataGridView_local_results)
        {
            string path = @"MyResults1.json";
            //string path = @"C:\Users\Alex\source\repos\Omlet144\Game_Kursak\bin\Debug\MyResults1.json";
            string json = null;
            try
            {
                string[] readText = File.ReadAllLines(path);
                foreach (string str in readText)
                {
                    json += str; 
                }

                list_result_statistics = JsonConvert.DeserializeObject<List<SaveResult>>(json);
                list_result_statistics.Sort((x, y) => y.client_Kills.CompareTo(x.client_Kills));

                DataTable dt = new DataTable();

                dt.Columns.Add("Nick name", typeof(string));
                dt.Columns.Add("Kills", typeof(int));
                dt.Columns.Add("Ammo picked up", typeof(int));
                dt.Columns.Add("Fired bullets", typeof(int));
                dt.Columns.Add("Med kit picked up", typeof(int));
                dt.Columns.Add("HP replenishment amount", typeof(int));
                dt.Columns.Add("Game time", typeof(string));

                foreach (var item in list_result_statistics)
                {
                    dt.Rows.Add(item.client_NickName, item.client_Kills, item.client_Ammo_picked_up, item.client_Fired_bullets, item.client_Med_kit_picked_up,
                        item.client_HP_replenishment_amount, item.client_Game_time);
                }
                dataGridView_local_results.DataSource = dt;
                for (int i = 0; i < dataGridView_local_results.RowCount; i++)
                {
                    dataGridView_local_results.Rows[i].ReadOnly = true;
                }
            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                dataGridView_local_results.DataSource = list_result_statistics;
                for (int i = 0; i < dataGridView_local_results.RowCount; i++)
                {
                    dataGridView_local_results.Rows[i].ReadOnly = true;
                }
            }
        }

        public string ConverResultsToJson(List<SaveResult> results)
        {
            string path = @"C:\Users\Alex\source\repos\Omlet144\Game_Kursak\bin\Debug\MyResults1.json";
            string json = null;
            string[] readText = File.ReadAllLines(path);
            foreach (string str in readText)
            {
                json += str;
            }

            results = JsonConvert.DeserializeObject<List<SaveResult>>(json);
            results.Sort((x, y) => y.client_Kills.CompareTo(x.client_Kills));
            json = JsonConvert.SerializeObject(results.Take(1), Formatting.Indented);

            List<Player_statistics_for_client> player_Statistics_For_Clients = new List<Player_statistics_for_client>();
            List<SaveResult> new_results = new List<SaveResult>();
            new_results = JsonConvert.DeserializeObject<List<SaveResult>>(json);

            foreach (var item in new_results)
            {
                player_Statistics_For_Clients.Add(new Player_statistics_for_client
                (
                    client_parametrs.userName,
                    client_parametrs.GetIpAddress(),
                    item.client_NickName,
                    item.client_Kills,
                    item.client_Ammo_picked_up,
                    item.client_Fired_bullets,
                    item.client_Med_kit_picked_up,
                    item.client_HP_replenishment_amount,
                    item.client_Game_time
                ));
            }
            json = JsonConvert.SerializeObject(player_Statistics_For_Clients, Formatting.Indented);
            return json;
        }

        public void ConverJsonToResults(string json, DataGridView dataGridView)
        {
            List<Player_statistics_for_client> player_Statistics_For_Clients = new List<Player_statistics_for_client>();
            player_Statistics_For_Clients = JsonConvert.DeserializeObject<List<Player_statistics_for_client>>(json);

            DataTable dt_Player_statistics = new DataTable();
            dt_Player_statistics.Columns.Add("Name PC", typeof(string));
            dt_Player_statistics.Columns.Add("IP adress", typeof(string));
            dt_Player_statistics.Columns.Add("Nick name", typeof(string));
            dt_Player_statistics.Columns.Add("Kills", typeof(int));
            dt_Player_statistics.Columns.Add("Ammo picked up", typeof(int));
            dt_Player_statistics.Columns.Add("Fired bullets", typeof(int));
            dt_Player_statistics.Columns.Add("Med kit picked up", typeof(int));
            dt_Player_statistics.Columns.Add("HP replenishment amount", typeof(int));
            dt_Player_statistics.Columns.Add("Game time", typeof(string));

            foreach (var item in player_Statistics_For_Clients)
            {
                dt_Player_statistics.Rows.Add
                    (
                        item.for_Name_PC,
                        item.for_Id_PC,
                        item.for_client_NickName,
                        item.for_client_Kills,
                        item.for_client_Ammo_picked_up,
                        item.for_client_Fired_bullets,
                        item.for_client_Med_kit_picked_up,
                        item.for_client_HP_replenishment_amount,
                        item.for_client_Game_time
                    );
            }
            if (dataGridView.DataSource != player_Statistics_For_Clients)
            {
                dataGridView.DataSource = dt_Player_statistics;
            }
           

        }

    }
}
