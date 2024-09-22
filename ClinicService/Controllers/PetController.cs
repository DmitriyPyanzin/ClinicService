using ClinicService.Models.Request;
using ClinicService.Models;
using ClinicService.Services;
using ClinicService.Services.Impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Reflection.Metadata;

namespace ClinicService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IPetRepository _petRepository;

        public PetController(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        [HttpPost("create")]
        [SwaggerOperation(OperationId = "PetCreate")]
        public ActionResult<int> Create([FromBody] CreatePetRequest createRequest)
        {
            int res = _petRepository.Create(new Pet
            {
                ClientId = createRequest.ClientId,
                Name = createRequest.Name,
                Type = createRequest.Type,
                Breed = createRequest.Breed,
                Birthday = createRequest.Birthday,
            });
            return Ok(res);
        }

        [HttpPut("update")]
        [SwaggerOperation(OperationId = "PetUpdate")]
        public ActionResult<int> Update([FromBody] UpdatePetRequest updateRequest)
        {
            int res = _petRepository.Update(new Pet
            {
                PetId = updateRequest.PetId,
                ClientId = updateRequest.ClientId,
                Name = updateRequest.Name,
                Type = updateRequest.Type,
                Breed = updateRequest.Breed,
                Birthday = updateRequest.Birthday,
            });
            return Ok(res);
        }

        [HttpDelete("delete")]
        [SwaggerOperation(OperationId = "PetDelete")]
        public ActionResult<int> Delete([FromQuery] int PetId)
        {
            int res = _petRepository.Delete(PetId);
            return Ok(res);
        }

        [HttpGet("get-all")]
        [SwaggerOperation(OperationId = "PetGetAll")]
        public ActionResult<List<Pet>> GetAll()
        {
            return Ok(_petRepository.GetAll());
        }

        [HttpGet("get/{petId}")]
        [SwaggerOperation(OperationId = "PetGetAllById")]
        public ActionResult<Pet> GetById([FromRoute] int petId)
        {
            return Ok(_petRepository.GetById(petId));
        }
    }
}
