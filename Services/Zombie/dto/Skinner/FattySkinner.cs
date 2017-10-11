using Services.Map;

namespace Services.Zombie.dto
{
    public class FattySkinner : ZombieSkinner
    {
        public FattySkinner(Location location) : base(location)
        {
            Priority = 6;
            Action = 1;
            MinDamage = 2;
            Experience = 1;
            Name = "Skinner Fatty";
            Type = ZombieMainTypeEnum.Fatty;

        }
    }
}
