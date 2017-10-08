using System;
using System.Collections.Generic;

namespace Services.Map
{
    //public class ZombicideMapFile
    //{
    //    public string File { get; private set; }
    //    public List<Location> ZombieStartLocations { get; private set; }
    //    public List<Location> Crosses { get; private set; }
    //    public List<Location[]> Doors { get; private set; }
    //    public List<Location> Exit { get; private set; }
    //    public List<Location> Start { get; private set; }
    //    public List<Location> Locations { get; private set; }
    //    public List<Connection> Connections { get; private set; }
    //    public int NodeNumber { get; set; }

    //    public ZombicideMapFile(string file)
    //    {
    //        File = file;
    //        Locations = new List<Location>();
    //        Connections = new List<Connection>();
    //        Doors = new List<Location[]>();
    //        ZombieStartLocations = new List<Location>();
    //        Exit = new List<Location>();
    //        Start = new List<Location>();
    //        Crosses = new List<Location>();
    //    }

    //    public void ReadFile()
    //    {
    //        //string[] lines = System.IO.File.ReadAllLines("/WpfLibrary;component/Assets/Maps/map1.txt");
    //        //string[] lines = System.IO.File.ReadAllLines("C:\\Users\\LandryC\\Documents\\Visual Studio 2015\\Projects\\ExoWPF\\ZombicideOpenMap\\ZombicideOpenMap\\map1.txt");
    //        //string[] lines = System.IO.File.ReadAllLines(File);

    //        var map = Zombicide.Properties.Resources.map1;
    //        string[] lines = map.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

    //        bool isNode = false;
    //        bool isLink = false;
    //        bool isZombie = false;
    //        bool isCross = false;
    //        bool isDoor = false;
    //        bool isExit = false;
    //        bool isStart = false;

    //        foreach (string line in lines)
    //        {
    //            switch (line)
    //            {
    //                case "node":
    //                    isNode = true;
    //                    isZombie = false;
    //                    isCross = false;
    //                    isDoor = false;
    //                    isExit = false;
    //                    isStart = false;
    //                    isLink = false;
    //                    break;

    //                case "link":
    //                    isNode = false;
    //                    isZombie = false;
    //                    isCross = false;
    //                    isDoor = false;
    //                    isExit = false;
    //                    isStart = false;
    //                    isLink = true;
    //                    break;

    //                case "door":
    //                    isNode = false;
    //                    isZombie = false;
    //                    isCross = false;
    //                    isDoor = true;
    //                    isExit = false;
    //                    isStart = false;
    //                    isLink = false;
    //                    break;

    //                case "zombiestart":
    //                    isNode = false;
    //                    isZombie = true;
    //                    isCross = false;
    //                    isDoor = false;
    //                    isExit = false;
    //                    isStart = false;
    //                    isLink = false;
    //                    break;

    //                case "start":
    //                    isNode = false;
    //                    isZombie = false;
    //                    isCross = false;
    //                    isDoor = false;
    //                    isExit = false;
    //                    isStart = true;
    //                    isLink = false;
    //                    break;

    //                case "exit":
    //                    isNode = false;
    //                    isZombie = false;
    //                    isCross = false;
    //                    isDoor = false;
    //                    isExit = true;
    //                    isStart = false;
    //                    isLink = false;
    //                    break;

    //                case "cross":
    //                    isNode = false;
    //                    isZombie = false;
    //                    isCross = true;
    //                    isDoor = false;
    //                    isExit = false;
    //                    isStart = false;
    //                    isLink = false;
    //                    break;

    //                default:
    //                    //Location
    //                    if (isNode && !string.IsNullOrWhiteSpace(line))
    //                    {
    //                        NodeNumber = Int32.Parse(line);
    //                        for (int i = 0; i < NodeNumber; i++)
    //                        {
    //                            Locations.Add(new Location(i.ToString()));
    //                        }
    //                    }

    //                    //Connection
    //                    if (isLink && !string.IsNullOrWhiteSpace(line))
    //                    {
    //                        var nodeLink = line.Split(' ');
    //                        Location initialLocation = null;
    //                        foreach (var loc in Locations)
    //                        {
    //                            if (loc.Identifier == nodeLink[0])
    //                            {
    //                                initialLocation = loc;
    //                                break;
    //                            }
    //                        }

    //                        for (int i = 1; i < nodeLink.Length; i++)
    //                        {
    //                            foreach (var loc in Locations)
    //                            {
    //                                if (loc.Identifier == nodeLink[i])
    //                                {
    //                                    Connections.Add(new Connection(initialLocation, loc, (int)WeightValue.Standard));
    //                                }
    //                            }
    //                            //Connections.Add(new Connection(new Location(nodeLink[0]), new Location(nodeLink[i]), (int)WeightValue.Standard));
    //                        }
    //                    }

    //                    //Zombie position
    //                    if (isZombie && !string.IsNullOrWhiteSpace(line))
    //                    {
    //                        foreach (var elt in line.Split(' '))
    //                        {
    //                            ZombieStartLocations.Add(new Location(elt.ToString()));
    //                        }
    //                    }

    //                    //cross position
    //                    if (isCross && !string.IsNullOrWhiteSpace(line))
    //                    {
    //                        foreach (var elt in line.Split(' '))
    //                        {
    //                            Crosses.Add(new Location(elt.ToString()));
    //                        }
    //                    }

    //                    //door position
    //                    if (isDoor && !string.IsNullOrWhiteSpace(line))
    //                    {
    //                        var doorTab = line.Split(' ');
    //                        Doors.Add(new Location[] { new Location(doorTab[0]), new Location(doorTab[1]) });
    //                    }

    //                    //exit position
    //                    if (isExit && !string.IsNullOrWhiteSpace(line))
    //                    {
    //                        foreach (var elt in line.Split(' '))
    //                        {
    //                            Exit.Add(new Location(elt.ToString()));
    //                        }
    //                    }

    //                    //start position
    //                    if (isStart && !string.IsNullOrWhiteSpace(line))
    //                    {
    //                        foreach (var elt in line.Split(' '))
    //                        {
    //                            Start.Add(new Location(elt.ToString()));
    //                        }
    //                    }
    //                    break;
    //            }
    //        }
    //        AddWeightFromDoor();
    //    }

    //    public void AddWeightFromDoor()
    //    {
    //        foreach (var door in Doors)
    //        {
    //            foreach (var connection in Connections)
    //            {
    //                if ((connection.A == door[0] && connection.B == door[1]) || (connection.A == door[1] && connection.B == door[0]))
    //                {
    //                    connection.Weight = (int)WeightValue.Door;
    //                }
    //            }
    //        }
    //    }
    //}

    public class ZombicideMapFile
    {
        public string Resource { get; private set; }
        public string Name { get; private set; }
        public List<Location> ZombieStartLocations { get; private set; }
        public List<Location> Crosses { get; private set; }
        public List<Location[]> Doors { get; private set; }
        public List<Location> Exit { get; private set; }
        public List<Location> Start { get; private set; }
        public List<Location> Locations { get; private set; }
        public List<Connection> Connections { get; private set; }
        public int NodeNumber { get; set; }

        public ZombicideMapFile(string resource, string name)
        {
            Resource = resource;
            Name = name;
            Locations = new List<Location>();
            Connections = new List<Connection>();
            Doors = new List<Location[]>();
            Crosses = new List<Location>();
            Exit = new List<Location>();
            Start = new List<Location>();
            ZombieStartLocations = new List<Location>();
        }

        public void ReadFile()
        {
            //var map = Zombicide.Properties.Resources.map1;
            string[] lines = Resource.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            bool isNode = false;
            bool isLink = false;
            bool isZombie = false;
            bool isCross = false;
            bool isDoor = false;
            bool isExit = false;
            bool isStart = false;

            foreach (string line in lines)
            {
                switch (line)
                {
                    case "node":
                        isNode = true;
                        isZombie = false;
                        isCross = false;
                        isDoor = false;
                        isExit = false;
                        isStart = false;
                        isLink = false;
                        break;

                    case "link":
                        isNode = false;
                        isZombie = false;
                        isCross = false;
                        isDoor = false;
                        isExit = false;
                        isStart = false;
                        isLink = true;
                        break;

                    case "door":
                        isNode = false;
                        isZombie = false;
                        isCross = false;
                        isDoor = true;
                        isExit = false;
                        isStart = false;
                        isLink = false;
                        break;

                    case "zombiestart":
                        isNode = false;
                        isZombie = true;
                        isCross = false;
                        isDoor = false;
                        isExit = false;
                        isStart = false;
                        isLink = false;
                        break;

                    case "start":
                        isNode = false;
                        isZombie = false;
                        isCross = false;
                        isDoor = false;
                        isExit = false;
                        isStart = true;
                        isLink = false;
                        break;

                    case "exit":
                        isNode = false;
                        isZombie = false;
                        isCross = false;
                        isDoor = false;
                        isExit = true;
                        isStart = false;
                        isLink = false;
                        break;

                    case "cross":
                        isNode = false;
                        isZombie = false;
                        isCross = true;
                        isDoor = false;
                        isExit = false;
                        isStart = false;
                        isLink = false;
                        break;

                    default:
                        //Location
                        if (isNode && !string.IsNullOrWhiteSpace(line))
                        {
                            NodeNumber = Int32.Parse(line);
                            for (int i = 0; i < NodeNumber; i++)
                            {
                                Locations.Add(new Location(i.ToString()));
                            }
                        }

                        //Connection
                        if (isLink && !string.IsNullOrWhiteSpace(line))
                        {
                            var nodeLink = line.Split(' ');
                            Location initialLocation = null;
                            foreach (var loc in Locations)
                            {
                                if (loc.Identifier == nodeLink[0])
                                {
                                    initialLocation = loc;
                                    break;
                                }
                            }

                            for (int i = 1; i < nodeLink.Length; i++)
                            {
                                foreach (var loc in Locations)
                                {
                                    if (loc.Identifier == nodeLink[i])
                                    {
                                        Connections.Add(new Connection(initialLocation, loc, 1));
                                    }
                                }
                            }
                        }

                        //Zombie position
                        if (isZombie && !string.IsNullOrWhiteSpace(line))
                        {
                            foreach (var elt in line.Split(' '))
                            {
                                foreach (var loc in Locations)
                                {
                                    if (loc.Identifier == elt)
                                    {
                                        ZombieStartLocations.Add(loc);
                                        break;
                                    }
                                }
                            }
                        }

                        //cross position
                        if (isCross && !string.IsNullOrWhiteSpace(line))
                        {
                            foreach (var elt in line.Split(' '))
                            {
                                foreach (var loc in Locations)
                                {
                                    if (loc.Identifier == elt)
                                    {
                                        Crosses.Add(new Location(elt.ToString()));
                                        break;
                                    }
                                }
                            }
                        }

                        //door position
                        if (isDoor && !string.IsNullOrWhiteSpace(line))
                        {
                            var doorTab = line.Split(' ');
                            Location loc1 = null;
                            Location loc2 = null;
                            foreach (var loc in Locations)
                            {
                                if (loc.Identifier == doorTab[0])
                                {
                                    loc1 = loc;
                                }
                                if (loc.Identifier == doorTab[1])
                                {
                                    loc2 = loc;
                                }
                            }
                            Doors.Add(new Location[] { loc1, loc2 });
                        }

                        //exit position
                        if (isExit && !string.IsNullOrWhiteSpace(line))
                        {
                            foreach (var elt in line.Split(' '))
                            {
                                foreach (var loc in Locations)
                                {
                                    if (loc.Identifier == elt)
                                    {
                                        Exit.Add(new Location(elt.ToString()));
                                        break;
                                    }
                                }
                            }
                        }

                        //start position
                        if (isStart && !string.IsNullOrWhiteSpace(line))
                        {
                            foreach (var elt in line.Split(' '))
                            {
                                foreach (var loc in Locations)
                                {
                                    if (loc.Identifier == elt)
                                    {
                                        Start.Add(new Location(elt.ToString()));
                                        break;
                                    }
                                }
                            }
                        }
                        break;
                }
            }
            AddWeightFromDoor();
        }
        public void AddWeightFromDoor()
        {
            foreach (var door in Doors)
            {
                foreach (var connection in Connections)
                {
                    if ((connection.A == door[0] && connection.B == door[1]) || (connection.A == door[1] && connection.B == door[0]))
                    {
                        connection.Weight = (int)WeightValue.Door;
                    }
                }
            }
        }
    }
}