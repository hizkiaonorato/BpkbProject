using BPKBBackendProject.Models.Location;

namespace BPKBBackendProject.Interfaces
{
    public interface ILocationRepository
    {
        IEnumerable<GetLocation> GetLocation();
        GetLocation GetLocationById(string id);
    }
}
