using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stable.Dtos;
using Stable.Models;
using Stable.Repositories;
using Stable.Specifications;

namespace Stable.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnersController : ControllerBase
    {
        private readonly IGeneicRepository<Owner> _repo;
     
        private readonly IMapper _mapper;

        public OwnersController(IGeneicRepository<Owner> Repo,IMapper mapper)
        {
            _repo = Repo;
           
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable< Owner>>> Get()
        {
            var spec = new OwnerSpecification();
            var owners = await _repo.GetAllWithSpecAsync(spec);
            return Ok(owners);
        }

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<Owner>> Get(string id)
        {
            var spec = new OwnerSpecification(id);
            var owner = await _repo.GetByIdWithSpecAsync(spec);
            if (owner == null)
                return NotFound();
            
            return Ok(owner);
        }
        [HttpPost]
        public async Task<ActionResult<Owner>> Create([FromForm] OwnerDTo model)
        {
            try
            {
                if (!ModelState.IsValid)
                   return BadRequest(ModelState);
                var newowner = new Owner
                {
                    Id=model.Id,
                    Name=model.Name,
                    Address=model.Address,
                    Age=model.Age,
                    Email=model.Email,
                    Gender=model.Gender,
                    Nationality= model.Nationality,
                    PhoneNumber=model.PhoneNumber,
                    
                };
                if (model.Photos.Count > 0)
                {
                    foreach (var photo in model.Photos)
                        newowner.AddImage(photo);
                }
                await _repo.CreateAsync(newowner);
               
                return Ok(newowner);
                
              
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }



        }

    }
}
