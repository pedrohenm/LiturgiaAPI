using LiturgiaAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LiturgiaAPI.Controllers
{
    [Route("api/evangelho")]
    public class EvangelhoController : ControllerBase
    {
        private readonly IEvangelhoRepository _repository;

        public EvangelhoController(IEvangelhoRepository repository)
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
