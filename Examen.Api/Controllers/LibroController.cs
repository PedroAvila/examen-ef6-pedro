using Eamen.Entities;
using Examen.Services.Dtos;
using Examen.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Api.Controllers
{
    [Route("api/libros")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly ILibroService _libroService;

        public LibroController(ILibroService libroService)
        {
            _libroService = libroService;
        }

        [HttpGet]
        public async Task<IEnumerable<Libro>> GetAll() 
        {
            return await _libroService.GetAllAsync();
        }

        [HttpPost]
        public async Task<IActionResult> Create(LibroDto dto)
        {
            await _libroService.CreateAsync(LibroDto.ToEntity(dto));
            return Ok(dto);
        }
    }
}
