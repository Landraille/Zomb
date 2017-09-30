using System.Collections.Generic;
using Domain.Map;

namespace Services.Map
{
    public interface IRouteEngineService
    {
        Dictionary<Location, Route> CalculateMinCost(Location startLocation);
    }
}