using System.Collections.Generic;

namespace Domain.Character
{
    public class CharacterPower
    {
        public List<PowerEnum> BluePower { get; set; }
        public PowerEnum YellowPower { get; set; }
        public PowerEnum OrangePower1 { get; set; }
        public PowerEnum OrangePower2 { get; set; }
        public PowerEnum RedPower1 { get; set; }
        public PowerEnum RedPower2 { get; set; }
        public PowerEnum RedPower3 { get; set; }
        public bool IsYellowPowerActivated { get; set; }
        public bool IsOrangePower1Activated { get; set; }
        public bool IsOrangePower2Activated { get; set; }
        public bool IsRedPower1Activated { get; set; }
        public bool IsRedPower2Activated { get; set; }
        public bool IsRedPower3Activated { get; set; }
    }
}