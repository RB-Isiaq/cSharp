using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.Services.Contracts.Institutions;
using Academy.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Academy.Presentation.Controllers
{

    public class InstitutionController : ControllerBase
    {
        private readonly ILogger<InstitutionController> _logger;
        private readonly IInstitutionService _institutionService;

        public InstitutionController(
            IInstitutionService institutionService,
            ILogger<InstitutionController> logger
        )
        {
            _institutionService = institutionService;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult<InstitutionCreateRes<InstitutionDto>> Create([FromBody] InstitutionCreateReq req)
        {
            return (IActionResult<InstitutionCreateRes<InstitutionDto>>)_institutionService.CreateInstitution(req);
        }
    }

    public interface IActionResult<T>
    {
    }
}