using LiturgiaAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiturgiaAPI.Controllers
{
    [Route("api/liturgia")]
    public class LiturgiaController : ControllerBase
    {
        private readonly ILiturgiaRepository _repository;

        public LiturgiaController(ILiturgiaRepository repository)
        {
            _repository = repository;
        }

        [Route("")]
        [HttpGet]
        public ActionResult ObterTodas()
        {
            var item = _repository.Get();
            return Ok(item);
        }

    }
}
