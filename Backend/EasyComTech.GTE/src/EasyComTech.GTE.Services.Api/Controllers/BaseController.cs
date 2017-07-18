using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyComTech.GTE.Services.Api.Controllers
{
    [Produces("application/json")]
    public class BaseController : Controller
    {

        protected new IActionResult Response(object result = null, bool operacaoOk = true)
        {
            if (operacaoOk)
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });
            }

            return BadRequest(new
            {
                success = false,
                errors = result
            });
        }
    }
}