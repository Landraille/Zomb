using Core;

namespace Domain.Zombie
{
    public abstract class Zombie
    {
        public int Action { get; protected set; }
        public int Experience { get; protected set; }
        public int MinDamage { get; protected set; }
        public int Priority { get; protected set; }
        public string Name { get; protected set; }
        public int ZonePerMove { get; protected set; }
    }
}