using Domain.Map;

namespace Domain.Zombie.Special
{
    public class Crowz : Zombie
    {
        public Crowz(Location location) : base(location)
        {
            Priority = 2;
            Action = 1;
            MinDamage = 1;
            Experience = 1;
            Name = "Murder of Crowz";
            Type = ZombieMainTypeEnum.Crowz;
            ZonePerMove = 3;
        }
    }
}