using LiturgiaAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LiturgiaAPI.Controllers
{
    [Route("api/salmo")]
    public class SalmoController : ControllerBase
    {
        private readonly ISalmoRepository _repository;

        public SalmoController(ISalmoRepository repository)
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