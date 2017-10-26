namespace Services.CardService.Dto
{
    public class MeleeWeaponDto : WeaponDto
    {
        public int? Dice { get; set; }
        public bool CanOpenDoor { get; set; }
        public bool CanOpenDoorSilently { get; set; }
        public bool CanKillSilently { get; set; }
    }
}