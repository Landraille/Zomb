using Services.CardService.Dto;

namespace Services.Character
{
    public class CharacterEquipment
    {
        public Equipment RightHand { get; set; }
        public Equipment LeftHand { get; set; }
        public Equipment Reserve1 { get; set; }
        public Equipment Reserve2 { get; set; }
        public Equipment Reserve3 { get; set; }

        public CharacterEquipment()
        {
            RightHand = null;
            LeftHand = null;
            Reserve1 = null;
            Reserve2 = null;
            Reserve3 = null;
        }
    }
}