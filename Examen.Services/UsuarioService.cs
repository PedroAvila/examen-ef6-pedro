using Eamen.Entities;
using Examen.Contract;
using Examen.Services.Interface;

namespace Examen.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRespository _usuarioRespository;

        public UsuarioService(IUsuarioRespository usuarioRespository)
        {
            _usuarioRespository = usuarioRespository;
        }

        public async Task CreateAsync(Usuario entity)
        {
            await _usuarioRespository.CreateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _usuarioRespository.DeleteAsync(id);
        }

        public Task<IEnumerable<Usuario>> GetAllAsync()
        {
            return _usuarioRespository.GetAllAsync();
        }

        public Task<Usuario> SingleAsync(int id)
        {
            return _usuarioRespository.SingleAsync(id);
        }

        public async Task UpdateAsync(Usuario entity)
        {
            await _usuarioRespository.UpdateAsync(entity);
        }
    }
}
