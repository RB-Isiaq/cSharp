using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Demo.Dtos.Institutions;
using Demo.Interfaces;
using Demo.Models;
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
        [Route("getbyid/{id}")]
        public ActionResult<Institution> GetInstitution(string institutionId)
        {
            _logger.LogInformation("Executing GetInstitution");
            if (!_institutionService.IsExist(institutionId))
            {
                return NotFound($"InstitutionId not found {institutionId}");
            }
            else
            {
                return _institutionService.GetInstitution(institutionId);
            }
        }

        [HttpPut]
        [Route("update/{id}")]
        public Institution Update(string institutionId, Institution institution)
        {
            _logger.LogInformation("Executing Update");
            return _institutionService.Update(institutionId, institution);
        }

        [HttpDelete]
        [Route("delete/{id}")]
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