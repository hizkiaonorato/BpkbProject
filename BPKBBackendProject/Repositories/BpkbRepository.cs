using AutoMapper;
using BPKBBackendProject.Interfaces;
using BPKBBackendProject.Models.Bpkb;

namespace BPKBBackendProject.Repositories
{
    public class BpkbRepository : IBpkbRepository
    {
        private DataContext _context;
        private readonly IMapper _mapper;
        public BpkbRepository(DataContext context, IMapper mapper)
        {
            _context= context;
            _mapper= mapper;
        }

        public void addBpkb(InsertBpkb model)
        {
            var data = _mapper.Map<tr_Bpkb>(model);

            _context.Bpkbs.Add(data);
            _context.SaveChanges();
        }
    }
}
