using System.Net;
using Eamen.Entities;
using Examen.Operation;
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
        public async Task<CustomResponse<IEnumerable<Usuario>>> GetAll()
        {
            return new CustomResponse<IEnumerable<Usuario>>((int)HttpStatusCode.OK, await _usuarioService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Single(int id)
        {
            try
            {
                var usuario = await _usuarioService.SingleAsync(id);
                var response = new CustomResponse<Usuario>((int)HttpStatusCode.OK, usuario);
                return Ok(response);
            }
            catch (CustomException e)
            {
                return StatusCode(e.Status, new CustomResponse<string>(e.Status, e.Mensaje!));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(UsuarioDto dto)
        {
            try
            {
                await _usuarioService.CreateAsync(UsuarioDto.ToEntity(dto));
                var response = new CustomResponse<UsuarioDto>((int)HttpStatusCode.OK, dto);
                return Ok(response);
            }
            catch (CustomException e)
            {
                return StatusCode(e.Status, new CustomResponse<string>(e.Status, e.Mensaje!));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
    }
}
