using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GTE.Application.Interfaces;

namespace EasyComTech.GTE.Services.Api.Controllers
{
    public class BestTimeToWorkController : BaseController
    {
        private readonly IBestTimeToWorkAppService _bestTimeAppService;

        public BestTimeToWorkController(IBestTimeToWorkAppService bestTimeAppService)
        {
            _bestTimeAppService = bestTimeAppService;
        }

        [HttpGet]
        [Route("get-all-best-time-to-work")]
        public IActionResult Get()
        {
            return Response(_bestTimeAppService.GetAll(), true);
        }
    }
}