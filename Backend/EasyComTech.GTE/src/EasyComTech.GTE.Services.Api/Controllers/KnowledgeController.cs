using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GTE.Application.Interfaces;

namespace EasyComTech.GTE.Services.Api.Controllers
{   
    public class KnowledgeController : BaseController
    {
        private readonly IKnowledgeAppService _knowledgeAppService;

        public KnowledgeController(IKnowledgeAppService knowledgeAppService)
        {
            _knowledgeAppService = knowledgeAppService;
        }

        [HttpGet]
        [Route("get-knowledge-by-id/{id:guid}")]
        public IActionResult Get(Guid id)
        {
            var knowledge = _knowledgeAppService.GetByIdProgrammer(id);

            return Response(knowledge, true);
        }
    }
}