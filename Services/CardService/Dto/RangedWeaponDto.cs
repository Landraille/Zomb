namespace Services.CardService.Dto
{
    public class RangedWeaponDto : WeaponDto
    {
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
        public bool HasToReload { get; set; }
        public bool CanKillSilently { get; set; }
    }
}