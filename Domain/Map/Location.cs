namespace Domain.Map
{
    public class Location
    {
        public string Identifier { get; set; }

        public Location(string identifier)
        {
            Identifier = identifier;
        }

        public override string ToString()
        {
            return Identifier;
        }
    }
}