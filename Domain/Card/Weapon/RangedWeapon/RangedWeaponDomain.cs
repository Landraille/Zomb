namespace Domain.Card.Weapon.RangedWeapon
{
    public class RangedWeaponDomain : WeaponDomain
    {
        public int? Dice { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
        public bool HasToReload { get; set; }
        public bool CanKillSilently { get; set; }
    }
}