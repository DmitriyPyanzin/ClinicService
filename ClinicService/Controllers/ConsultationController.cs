using ClinicService.Models.Request;
using ClinicService.Models;
using ClinicService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClinicService.Services.Impl;
using Swashbuckle.AspNetCore.Annotations;
using System.Reflection.Metadata;

namespace ClinicService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultationController : ControllerBase
    {
        private readonly IConsultationRepository _consultationRepository;

        public ConsultationController(IConsultationRepository consultationRepository)
        {
            _consultationRepository = consultationRepository;
        }

        [HttpPost("create")]
        [SwaggerOperation(OperationId = "ConsultationCreate")]
        public ActionResult<int> Create([FromBody] CreateConsultationRequest createRequest)
        {
            int res = _consultationRepository.Create(new Consultation
            {
                ClientId = createRequest.ClientId,
                PetId = createRequest.PetId,
                ConsultationDate = createRequest.ConsultationDate,
                Description = createRequest.Description
            });
            return Ok(res);
        }

        [HttpPut("update")]
        [SwaggerOperation(OperationId = "ConsultationUpdate")]
        public ActionResult<int> Update([FromBody] UpdateConsultationRequest updateRequest)
        {
            int res = _consultationRepository.Update(new Consultation
            {
                ConsultationId = updateRequest.ConsultationId,
                ClientId = updateRequest.ClientId,
                PetId = updateRequest.PetId,
                ConsultationDate = updateRequest.ConsultationDate,
                Description = updateRequest.Description
            });
            return Ok(res);
        }

        [HttpDelete("delete")]
        [SwaggerOperation(OperationId = "ConsultationDelete")]
        public ActionResult<int> Delete([FromQuery] int ConsultationId)
        {
            int res = _consultationRepository.Delete(ConsultationId);
            return Ok(res);
        }

        [HttpGet("get-all")]
        [SwaggerOperation(OperationId = "ConsultationGetAll")]
        public ActionResult<List<Consultation>> GetAll()
        {
            return Ok(_consultationRepository.GetAll());
        }

        [HttpGet("get/{consultationId}")]
        [SwaggerOperation(OperationId = "ConsultationGetAllById")]
        public ActionResult<Consultation> GetById([FromRoute] int consultationId)
        {
            return Ok(_consultationRepository.GetById(consultationId));
        }
    }
}
