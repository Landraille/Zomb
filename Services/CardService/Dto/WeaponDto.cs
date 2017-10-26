namespace Services.CardService.Dto
{
    public abstract class WeaponDto : EquipmentDto
    {
        public int? MinDiceResult { get; set; }
        public int Damage { get; set; }
        public bool CanBeDual { get; set; }
        public bool IsPimpWeapon { get; set; }
        public bool IsUltraRedWeapon { get; set; }
    }
}