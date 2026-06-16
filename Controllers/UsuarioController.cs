using Microsoft.AspNetCore.Mvc;
using CltinderApi.Services;
using CltinderApi.Models;

namespace CltinderApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService service;

        public UsuarioController(UsuarioService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult Get()
            => Ok(service.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var usuario = service.GetById(id);
            if (usuario == null) return NotFound();
            return Ok(usuario);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            var novo = service.Add(usuario);
            return Created("", novo);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Usuario usuario)
        {
            if (!service.Update(id, usuario))
                return NotFound();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (!service.Delete(id))
                return NotFound();

            return Ok();
        }
    }
}