namespace Game_Kursak.model
{
    public class SaveResult
    {
        public string client_NickName { get; set; }
        public int client_Kills { get; set; }
        public int client_Ammo_picked_up { get; set; }
        public int client_Fired_bullets { get; set; }
        public int client_Med_kit_picked_up { get; set; }
        public int client_HP_replenishment_amount { get; set; }
        public string client_Game_time { get; set; }

        public SaveResult()
        {
            this.client_NickName = "";
            this.client_Kills = 0;
            this.client_Ammo_picked_up = 0;
            this.client_Fired_bullets = 0;
            this.client_Med_kit_picked_up = 0;
            this.client_HP_replenishment_amount = 0;
            this.client_Game_time = "";
        }

        public SaveResult(string nickName, int kills, int ammo_picked_up, int fired_bullets, int med_kit_picked_up, int hP_replenishment_amount, string game_time)
        {
            this.client_NickName = nickName;
            this.client_Kills = kills;
            this.client_Ammo_picked_up = ammo_picked_up;
            this.client_Fired_bullets = fired_bullets;
            this.client_Med_kit_picked_up = med_kit_picked_up;
            this.client_HP_replenishment_amount = hP_replenishment_amount;
            this.client_Game_time = game_time;
        }
    }
}
