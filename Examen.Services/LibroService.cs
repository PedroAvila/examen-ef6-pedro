using Eamen.Entities;
using Examen.Contract;
using Examen.Services.Interface;

namespace Examen.Services
{
    public class LibroService : ILibroService
    {
        private ILibroRepository _libroRepository;

        public LibroService(ILibroRepository libroRepository)
        {
            _libroRepository = libroRepository;
        }

        public async Task CreateAsync(Libro entity)
        {
            await _libroRepository.CreateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _libroRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Libro>> GetAllAsync()
        {
            return await _libroRepository.GetAllAsync();
        }

        public Task<Libro> SingleAsync(int id)
        {
            return _libroRepository.SingleAsync(id);
        }

        public async Task UpdateAsync(Libro entity)
        {
            await _libroRepository.UpdateAsync(entity);
        }
    }
}
