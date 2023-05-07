namespace Game_Kursak.model
{
     internal class Player
    {
       public bool goLeft, goRight, goUp, goDown, gameOver;
        public string facing;
        public double playerHealth;
        public int speed;
        public int ammo;
        public int score;

        public Player(string facing, int playerHealth, int speed, int ammo) 
        {
            this.facing = facing;
            this.playerHealth = playerHealth;
            this.speed = speed; 
            this.ammo = ammo;
        }
    }
}
