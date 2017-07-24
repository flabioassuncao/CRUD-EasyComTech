using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GTE.Application.Interfaces;

namespace EasyComTech.GTE.Services.Api.Controllers
{
    public class BankInformationController : BaseController
    {
        private readonly IBankInformationAppService _bankAppService;

        public BankInformationController(IBankInformationAppService bankAppService)
        {
            _bankAppService = bankAppService;
        }

        [HttpGet]
        [Route("get-bank-information-by-id/{id:guid}")]
        public IActionResult Get(Guid id)
        {
            var bank = _bankAppService.GetByIdProgrammer(id);

            return Response(bank, true);
        }
    }
}