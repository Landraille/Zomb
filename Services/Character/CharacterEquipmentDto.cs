using Services.CardService.Dto;

namespace Services.Character
{
    public class CharacterEquipmentDto
    {
        public EquipmentDto RightHand { get; set; }
        public EquipmentDto LeftHand { get; set; }
        public EquipmentDto Reserve1 { get; set; }
        public EquipmentDto Reserve2 { get; set; }
        public EquipmentDto Reserve3 { get; set; }

        public CharacterEquipmentDto()
        {
            RightHand = null;
            LeftHand = null;
            Reserve1 = null;
            Reserve2 = null;
            Reserve3 = null;
        }
    }
}