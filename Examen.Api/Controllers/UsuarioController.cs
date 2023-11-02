using Eamen.Entities;
using Examen.Services.Dtos;
using Examen.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Api.Controllers
{
    [Route("api/usuarios")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public Task<IEnumerable<Usuario>> GetAll()
        {
            return _usuarioService.GetAllAsync();
        }

        [HttpPost]
        public async Task<IActionResult> Create(UsuarioDto dto)
        {
            await _usuarioService.CreateAsync(UsuarioDto.ToEntity(dto));
            return Ok(dto);
        }

        

    }
}
