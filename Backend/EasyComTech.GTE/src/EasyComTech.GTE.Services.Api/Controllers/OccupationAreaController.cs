using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GTE.Application.Interfaces;

namespace EasyComTech.GTE.Services.Api.Controllers
{
    
    public class OccupationAreaController : BaseController
    {
        private readonly IOccupationAreaAppService _occupationAppService;

        public OccupationAreaController(IOccupationAreaAppService occupationAppService)
        {
            _occupationAppService = occupationAppService;
        }

        [HttpGet]
        [Route("get-occupation-area-by-id/{id:guid}")]
        public IActionResult Get(Guid id)
        {
            var occupation = _occupationAppService.GetByIdProgrammer(id);

            return Response(occupation, true);
        }
    }
}