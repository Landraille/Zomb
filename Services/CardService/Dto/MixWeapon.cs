namespace Services.CardService.Dto
{
    public class MixWeapon : Equipment
    {
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
        public int? MeleeDice { get; set; }
        public int? RangedDice { get; set; }
        public int? MinDiceResult { get; set; }
        public int Damage { get; set; }
        public bool CanOpenDoor { get; set; }
        public bool CanOpenDoorSilently { get; set; }
        public bool CanMeleeKillSilently { get; set; }
        public bool CanRangedKillSilently { get; set; }
        public bool CanBeDual { get; set; }
        public bool HasToReload { get; set; }
        public bool IsPimpWeapon { get; set; }
        public bool IsUltraRedWeapon { get; set; }

        public MixWeapon(ZombicideGameEnum zombicideGame, 
                      int number, 
                      string name, 
                      string description, 
                      int minRange,
                      int maxRange,
                      int? meleeDice,
                      int? rangedDice,
                      int? minDiceResult,
                      int damage,
                      bool canOpenDoor,
                      bool canOpenDoorSilently,
                      bool canMeleeKillSilently,
                      bool canRangedKillSilently,
                      bool canBeDual) 
            : base(zombicideGame, number, name, description)
        {
            MinRange = minRange;
            MaxRange = maxRange;
            MeleeDice = meleeDice;
            RangedDice = rangedDice;
            MinDiceResult = minDiceResult;
            Damage = damage;
            CanOpenDoor = canOpenDoor;
            CanOpenDoorSilently = canOpenDoorSilently;
            CanMeleeKillSilently = canMeleeKillSilently;
            CanRangedKillSilently = canRangedKillSilently;
            CanBeDual = canBeDual;
            IsPimpWeapon = false;
            IsUltraRedWeapon = false;
        }
    }
}