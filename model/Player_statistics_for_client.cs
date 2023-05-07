namespace Game_Kursak.model
{
    internal class Player_statistics_for_client
    {
        public string for_Name_PC { get; set; }
        public string for_Id_PC { get; set; }
        public string for_client_NickName { get; set; }
        public int for_client_Kills { get; set; }
        public int for_client_Ammo_picked_up { get; set; }
        public int for_client_Fired_bullets { get; set; }
        public int for_client_Med_kit_picked_up { get; set; }
        public int for_client_HP_replenishment_amount { get; set; }
        public string for_client_Game_time { get; set; }

        public Player_statistics_for_client(string NamePC, string IdPC, string nickName, int kills, int ammo_picked_up, int fired_bullets, int med_kit_picked_up, int hP_replenishment_amount, string game_time)
        {
            this.for_Name_PC = NamePC;
            this.for_Id_PC = IdPC;
            this.for_client_NickName = nickName;
            this.for_client_Kills = kills;
            this.for_client_Ammo_picked_up = ammo_picked_up;
            this.for_client_Fired_bullets = fired_bullets;
            this.for_client_Med_kit_picked_up = med_kit_picked_up;
            this.for_client_HP_replenishment_amount = hP_replenishment_amount;
            this.for_client_Game_time = game_time;
        }
    }
}
