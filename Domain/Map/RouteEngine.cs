using System.Collections.Generic;
using System.Linq;

namespace Domain.Map
{
    public class RouteEngine
    {
        public List<Connection> Connections { get; set; }
        public List<Location> Locations { get; set; }

        public RouteEngine(List<Connection> connections, List<Location> locations)
        {
            Connections = connections;
            Locations = locations;
        }

        /// <summary>
        /// Calculates the shortest route to all the other locations
        /// taken from http://www.codeproject.com/Articles/22647/Dijkstra-Shortest-Route-Calculation-Object-Oriente
        /// </summary>
        /// <param name="startLocation"></param>
        /// <returns>List of all locations and their shortest route</returns>
        public Dictionary<Location, Route> CalculateMinCost(Location startLocation)
        {
            //Initialise a new empty route list
            Dictionary<Location, Route> shortestPaths = new Dictionary<Location, Route>();
            //Initialise a new empty handled locations list
            List<Location> _handledLocations = new List<Location>();

            //Initialise the new routes. the constructor will set the route weight to in.max
            foreach (Location location in Locations)
            {
                shortestPaths.Add(location, new Route(location.Identifier));
            }

            //The startPosition has a weight 0. 
            shortestPaths[startLocation].Cost = 0;


            //If all locations are handled, stop the engine and return the result
            while (_handledLocations.Count != Locations.Count)
            {
                //Order the locations
                List<Location> shortestLocations = (List<Location>)(from s in shortestPaths
                                                                     orderby s.Value.Cost
                                                                     select s.Key).ToList();


                Location locationToProcess = null;

                //Search for the nearest location that isn't handled
                foreach (Location location in shortestLocations)
                {
                    if (!_handledLocations.Contains(location))
                    {
                        //If the cost equals int.max, there are no more possible connections to the remaining locations
                        if (shortestPaths[location].Cost == int.MaxValue)
                            return shortestPaths;
                        locationToProcess = location;
                        break;
                    }
                }

                //Select all connections where the startposition is the location to Process
                var selectedConnections = from c in Connections
                                           where c.A == locationToProcess
                                           select c;

                //Iterate through all connections and search for a connection which is shorter
                foreach (Connection conn in selectedConnections)
                {
                    if (shortestPaths[conn.B].Cost > conn.Weight + shortestPaths[conn.A].Cost)
                    {
                        shortestPaths[conn.B].Connections = shortestPaths[conn.A].Connections.ToList();
                        shortestPaths[conn.B].Connections.Add(conn);
                        shortestPaths[conn.B].Cost = conn.Weight + shortestPaths[conn.A].Cost;
                    }
                }
                //Add the location to the list of processed locations
                _handledLocations.Add(locationToProcess);
            }


            return shortestPaths;
        }




    }

}