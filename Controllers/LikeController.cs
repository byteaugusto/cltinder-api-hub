using Microsoft.AspNetCore.Mvc;
using CltinderApi.Services;
using CltinderApi.Models;

namespace CltinderApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LikeController : ControllerBase
    {
        private readonly LikeService service;

        public LikeController(LikeService service)
        {
            this.service = service;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Like like)
        {
            service.Add(like);
            return Ok(new { mensagem = "Like registrado" });
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetAll());
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var like = service.GetById(id);

            if (like == null)
                return NotFound("Like não encontrado");

            service.Delete(id);

            return Ok("Like removido com sucesso");
        }
    }
}