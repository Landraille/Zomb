namespace Domain.Card.Weapon
{
    public abstract class WeaponDomain
    {
        public string Name { get; set; }
        public bool InDeck { get; set; }
        public int? MinDiceResult { get; set; }
        public int Damage { get; set; }
        public bool CanBeDual { get; set; }
        public bool IsPimpWeapon { get; set; }
        public bool IsUltraRedWeapon { get; set; }
    }
}