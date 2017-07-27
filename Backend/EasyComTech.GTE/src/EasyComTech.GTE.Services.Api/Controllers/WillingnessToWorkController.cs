using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GTE.Application.Interfaces;

namespace EasyComTech.GTE.Services.Api.Controllers
{
    
    public class WillingnessToWorkController : BaseController
    {
        private readonly IWillingnessToWorkAppService _willAppService;

        public WillingnessToWorkController(IWillingnessToWorkAppService willAppService)
        {
            _willAppService = willAppService;
        }

        [HttpGet]
        [Route("get-all-willingness-to-work")]
        public IActionResult Get()
        {
            return Response(_willAppService.GetAll(), true);
        }
    }
}