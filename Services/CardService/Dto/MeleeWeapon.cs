namespace Services.CardService.Dto
{
    public class MeleeWeapon : Equipment
    {
        public int? Dice { get; set; }
        public int? MinDiceResult { get; set; }
        public int Damage { get; set; }
        public bool CanOpenDoor { get; set; }
        public bool CanOpenDoorSilently { get; set; }
        public bool CanKillSilently { get; set; }
        public bool CanBeDual { get; set; }
        public bool IsPimpWeapon { get; set; }
        public bool IsUltraRedWeapon { get; set; }

        public MeleeWeapon(ZombicideGameEnum zombicideGame, 
                      int number, 
                      string name, 
                      string description, 
                      int? dice, 
                      int? minDiceResult,
                      int damage,
                      bool canOpenDoor,
                      bool canOpenDoorSilently,
                      bool canKillSilently,
                      bool canBeDual) 
            : base(zombicideGame, number, name, description)
        {
            Dice = dice;
            MinDiceResult = minDiceResult;
            Damage = damage;
            CanOpenDoor = canOpenDoor;
            CanOpenDoorSilently = canOpenDoorSilently;
            CanKillSilently = canKillSilently;
            CanBeDual = canBeDual;
            IsPimpWeapon = false;
            IsUltraRedWeapon = false;
        }
    }
}