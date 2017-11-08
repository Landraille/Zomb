
namespace Domain.Card.Zombie
{
    public class ZombieCardDomain
    {
        public InvasionDomain BlueInvasion { get; set; }
        public InvasionDomain YellowInvasion { get; set; }
        public InvasionDomain OrangeInvasion { get; set; }
        public InvasionDomain RedInvasion { get; set; }
        public bool IsSewerInvasion { get; set; }
        public bool IsBlueBedInvasion { get; set; }
        public bool IsGreenBedInvasion { get; set; }
        public bool IsSupplementaryActivation { get; set; }
    }

    public class InvasionDomain
    {
        public int ZombieNumber { get; set; }
        public string ZombieType { get; set; }
    }
}