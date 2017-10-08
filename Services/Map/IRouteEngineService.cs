using System.Collections.Generic;

namespace Services.Map
{
    public interface IRouteEngineService
    {
        Dictionary<Location, Route> CalculateMinCost(Location startLocation);
    }
}