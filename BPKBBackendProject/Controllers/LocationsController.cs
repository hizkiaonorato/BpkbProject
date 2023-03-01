using AutoMapper;
using BPKBBackendProject.Interfaces;
using BPKBBackendProject.Models;
using BPKBBackendProject.Models.Location;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BPKBBackendProject.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private ILocationRepository _repository;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;

        public LocationsController(ILocationRepository repository, IMapper mapper, IOptions<AppSettings> appSettings)
        {
            _repository = repository;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }
        // GET: api/<LocationsController>
        [HttpGet]
        public IEnumerable<GetLocation> Get()
        {
            return _repository.GetLocation();
        }

        // GET api/<LocationsController>/5
        [HttpGet("{id}")]
        public GetLocation Get(string id)
        {
            return _repository.GetLocationById(id);
        }
    }
}
