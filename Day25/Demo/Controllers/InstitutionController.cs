using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Demo.Dtos;
using Demo.Dtos.Institutions;
using Demo.Extensions;
using Demo.Interfaces;
using Demo.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InstitutionController : ControllerBase
    {
        private readonly IInstitutionService _institutionService;
        private readonly ILogger<InstitutionController> _logger;
        public InstitutionController(
            IInstitutionService institutionService,
            ILogger<InstitutionController> logger
            )
        {
            _institutionService = institutionService;
            _logger = logger;
        }

        [HttpGet]
        [Route("all")]
        public ActionResult<List<Institution>> GetInstitutions()
        {
            _logger.LogInformation("Executing GetInstitutions");
            return _institutionService.GetInstitutions();
        }

        [HttpGet]
        [Route("getbyid")]
        public ActionResult<GenericResponse<GetInstittutionDto>> GetInstitution(string institutionId)
        {
            _logger.LogInformation("Executing GetInstitution");
            if (!_institutionService.IsExist(institutionId))
            {
                return NotFound($"InstitutionId not found {institutionId}");
            }
            else
            {
                var result = new GenericResponse<GetInstittutionDto>()
                {
                    Code = "200",
                    Message = "Success",
                    Result = _institutionService.GetInstitution(institutionId).InstitutionToGetInstitutionDto()

                };
                return Ok(result);
            }
        }

        [HttpPut]
        [Route("update")]
        public ActionResult<Institution> Update(string institutionId, [FromBody] UpdateInstitutionRequest institutionReq)
        {
            _logger.LogInformation("Executing Update");
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var updatedInstitution = new Institution
            {
                City = institutionReq.City,
                Name = institutionReq.Name,
                Id = institutionReq.Id
            };
            _institutionService.Update(institutionId, updatedInstitution);
            return Ok(HttpStatusCode.OK);
        }

        [HttpDelete]
        [Route("delete")]
        public ActionResult<bool> Delete(string institutionId)
        {
            _logger.LogInformation("Executing Delete");
            if (!_institutionService.IsExist(institutionId))
            {
                return NotFound($"InstitutionId not found {institutionId}");
            }
            else
            {
                return Ok(_institutionService.Delete(institutionId));
            }

        }
        [HttpPost]
        [Route("add")]
        public ActionResult<Institution> Add(
            [FromBody] CreateInstitutionRequest institutionReq)
        {
            _logger.LogInformation("Executing AddInstitution");

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var newInstitution = new Institution
            {
                City = institutionReq.City,
                Name = institutionReq.Name,
                Id = institutionReq.Id
            };

            _institutionService.Add(newInstitution);
            return Ok(HttpStatusCode.Created);

        }
    }
}