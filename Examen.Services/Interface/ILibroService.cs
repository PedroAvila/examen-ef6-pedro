using Eamen.Entities;

namespace Examen.Services.Interface
{
    public interface ILibroService
    {
        Task<IEnumerable<Libro>> GetAllAsync();
        Task<Libro> SingleAsync(int id);
        Task CreateAsync(Libro entity);
        Task UpdateAsync(Libro entity);
        Task DeleteAsync(int id);
    }
}
