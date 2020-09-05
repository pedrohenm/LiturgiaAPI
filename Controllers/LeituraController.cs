using LiturgiaAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LiturgiaAPI.Controllers
{
    [Route("api/leitura")]
    public class LeituraController : ControllerBase
    {
        private readonly ILeituraRepository _repository;

        public LeituraController(ILeituraRepository repository)
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
