using Domain.Map;

namespace Domain.Zombie
{
    public abstract class Zombie
    {
        public Location Location { get; protected set; }
        public int Action { get; protected set; }
        public int Experience { get; protected set; }
        public int MinDamage { get; protected set; }
        public int Priority { get; protected set; }
        public bool HasPlayed { get; protected set; }
        public string Name { get; protected set; }
        public bool IsToxic { get; protected set; }
        public bool IsBerserk { get; protected set; }
        public bool IsSkinner { get; protected set; }
        public ZombieMainTypeEnum Type { get; protected set; }
        public int ZonePerMove { get; protected set; }


        protected Zombie(Location location)
        {
            HasPlayed = false;
            Location = location;
            ZonePerMove = 1;
        }
    }


}