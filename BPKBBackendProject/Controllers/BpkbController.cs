using AutoMapper;
using BPKBBackendProject.Interfaces;
using BPKBBackendProject.Models;
using BPKBBackendProject.Models.Bpkb;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BPKBBackendProject.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BpkbController : ControllerBase
    {
        private IBpkbRepository _repository;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;

        public BpkbController(IBpkbRepository repository, IMapper mapper, IOptions<AppSettings> appSettings)
        {
            _repository = repository;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }

        // POST api/<BpkbController>
        [HttpPost]
        public ActionResult Post(InsertBpkb model)
        {
            _repository.addBpkb(model);
            return Ok(new { message = "Registration successful" });
        }
    }
}
