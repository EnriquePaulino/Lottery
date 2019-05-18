namespace Lottery.Web.Controllers.API
{
    using Data;
    using Lottery.Web.Data.Repositories;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[Controller]")]
    public class BancasController : Controller
    {
        private readonly IBancaRepository bancaRepository;

        public BancasController(IBancaRepository bancaRepository)
        {
            this.bancaRepository = bancaRepository;
        }

        [HttpGet]
        public IActionResult GetBancas()
        {
            return this.Ok(this.bancaRepository.GetAll());
        }
    }
}
