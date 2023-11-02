using Eamen.Entities;
using Examen.Services.Interface;

namespace Examen.Services
{
    public class LibroService : ILibroService
    {
        private ILibroService _libroService;

        public LibroService(ILibroService libroService)
        {
            _libroService = libroService;
        }

        public async Task CreateAsync(Libro entity)
        {
            await _libroService.CreateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _libroService.DeleteAsync(id);
        }

        public async Task<IEnumerable<Libro>> GetAllAsync()
        {
            return await _libroService.GetAllAsync();
        }

        public Task<Libro> SingleAsync(int id)
        {
            return _libroService.SingleAsync(id);
        }

        public async Task UpdateAsync(Libro entity)
        {
            await _libroService.UpdateAsync(entity);
        }
    }
}
