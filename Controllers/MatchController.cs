using Microsoft.AspNetCore.Mvc;
using CltinderApi.Services;
using CltinderApi.Models;

namespace CltinderApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MatchController : ControllerBase
    {
        private readonly MatchService service;

        public MatchController(MatchService service)
        {
            this.service = service;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Match match)
        {
            service.Add(match);
            return Ok(new { mensagem = "Match criado" });
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetAll());
        }
    }
}