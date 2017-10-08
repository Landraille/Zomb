using System.Collections.Generic;

namespace Services.Map
{
    public class Route
    {
        public int Cost { get; set; }
        public List<Connection> Connections { get; set; }
        public string Identifier { get; set; }

        public Route(string _identifier)
        {
            Cost = int.MaxValue;
            Connections = new List<Connection>();
            Identifier = _identifier;
        }

        public override string ToString()
        {
            return "Id:" + Identifier + " Cost:" + Cost;
        }
    }
}