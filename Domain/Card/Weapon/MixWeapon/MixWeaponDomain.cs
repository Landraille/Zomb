namespace Domain.Card.Weapon.MixWeapon
{
    public class MixWeaponDomain : WeaponDomain
    {
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
        public int? MeleeDice { get; set; }
        public int? RangedDice { get; set; }
        public bool CanOpenDoor { get; set; }
        public bool CanOpenDoorSilently { get; set; }
        public bool CanMeleeKillSilently { get; set; }
        public bool CanRangedKillSilently { get; set; }
        public bool HasToReload { get; set; }
    }
}