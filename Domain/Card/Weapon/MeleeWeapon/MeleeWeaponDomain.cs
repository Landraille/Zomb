namespace Domain.Card.Weapon.MeleeWeapon
{
    public class MeleeWeaponDomain : WeaponDomain
    {
        public int? Dice { get; set; }
        public bool CanOpenDoor { get; set; }
        public bool CanOpenDoorSilently { get; set; }
        public bool CanKillSilently { get; set; }
    }
}