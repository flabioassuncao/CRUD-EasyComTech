using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GTE.Application.Interfaces;

namespace EasyComTech.GTE.Services.Api.Controllers
{
    public class AccountTypeController : BaseController
    {
        private readonly IAccountTypeAppService _accountAppService;

        public AccountTypeController(IAccountTypeAppService accountAppService)
        {
            _accountAppService = accountAppService;
        }

        [HttpGet]
        [Route("get-all-accout-type")]
        public IActionResult Get()
        {
            return Response(_accountAppService.GetAll(), true);
        }
    }
}