
namespace Domain.Map
{
    public class Connection
    {
        public Location A { get; set; }
        public Location B { get; set; }
        public int Weight { get; set; }
        bool selected = false;

        public bool Selected
        {
            get { return selected; }
            set { selected = value; }
        }

        public Connection(Location a, Location b, int weight)
        {
            A = a;
            B = b;
            Weight = weight;
        }

    }
}