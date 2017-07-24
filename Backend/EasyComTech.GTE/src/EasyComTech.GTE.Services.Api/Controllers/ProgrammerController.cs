using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GTE.Application.Interfaces;
using GTE.Application.ViewModels;

namespace EasyComTech.GTE.Services.Api.Controllers
{
    public class ProgrammerController : BaseController
    {
        private readonly IProgrammerAppService _programmerAppService;

        public ProgrammerController(IProgrammerAppService programmerAppService)
        {
            _programmerAppService = programmerAppService;
        }

        [HttpGet]
        [Route("get-all-programmers")]
        public IActionResult Get()
        {
            return Response(_programmerAppService.GetAllProgrammers().ToList());
        }

        [HttpGet]
        [Route("get-programmer-by-id/{id:guid}")]
        public IActionResult Get(Guid id)
        {
            return Response(_programmerAppService.GetById(id));
        }

        [HttpPost]
        [Route("add-programmer")]
        public IActionResult Post([FromBody] ProgrammerViewModel model)
        {
            _programmerAppService.AddProgrammer(model);
            return Response();
        }

        [HttpPut]
        [Route("update-programmer")]
        public IActionResult Put([FromBody] ProgrammerViewModel model)
        {
            _programmerAppService.UpdateProgramer(model);
            return Response();
        }

        [HttpDelete]
        [Route("delete-programmer/{id:guid}")]
        public IActionResult Delete(Guid id)
        {
            _programmerAppService.Remove(id);
            return Response();
        }
    }
}