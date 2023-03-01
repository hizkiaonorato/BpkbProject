using AutoMapper;
using BPKBBackendProject.Interfaces;
using BPKBBackendProject.Models.Location;

namespace BPKBBackendProject.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private DataContext _context;
        private readonly IMapper _mapper;
        public LocationRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IEnumerable<GetLocation> GetLocation()
        {
            var datas = _context.Locations;
            var result = _mapper.Map<IEnumerable<GetLocation>>(datas);
            return result;
        }

        public GetLocation GetLocationById(string id)
        {
            var data = _context.Locations.Find(id);
            if(data == null)
            {
                throw new KeyNotFoundException("User not found");
            }
            var result = _mapper.Map<GetLocation>(data);
            return result;
        }
    }
}
