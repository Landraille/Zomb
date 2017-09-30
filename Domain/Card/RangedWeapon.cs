namespace Domain.Card
{
    public class RangedWeapon : MeleeWeapon
    {
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
        public bool HasToReload { get; set; }

        public RangedWeapon(ZombicideGameEnum zombicideGame, 
                      int number, 
                      string name, 
                      string description, 
                      int minRange, 
                      int maxRange, 
                      int? dice, 
                      int? minDiceResult,
                      int damage,
                      bool canOpenDoor,
                      bool canOpenDoorSilently,
                      bool canKillSilently,
                      bool canBeDual) 
            : base(zombicideGame, number, name, description, dice, minDiceResult, damage, canOpenDoor, canOpenDoorSilently, canKillSilently, canBeDual)
        {
            MinRange = minRange;
            MaxRange = maxRange;
            HasToReload = false;
        }
    }
}