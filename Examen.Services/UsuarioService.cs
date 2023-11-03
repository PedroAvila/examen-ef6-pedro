using System.Net;
using Eamen.Entities;
using Examen.Contract;
using Examen.Operation;
using Examen.Services.Interface;

namespace Examen.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly UsuarioValidator _usuarioValidator = new();
        private readonly IUsuarioRespository _usuarioRespository;

        public UsuarioService(IUsuarioRespository usuarioRespository)
        {
            _usuarioRespository = usuarioRespository;
        }

        public async Task CreateAsync(Usuario entity)
        {
            var validate = _usuarioValidator.Validate(entity);
            if (!validate.IsValid)
                throw new BusinessException(Validator.GetErrorMessages(validate.Errors), HttpStatusCode.BadRequest);
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

        public async Task<Usuario> SingleAsync(int id)
        {
            var exist = await _usuarioRespository.ExistAsync(x => x.UsuarioId == id);
            if (!exist)
                throw new BusinessException("Usuario no existe", HttpStatusCode.NotFound);

            return await _usuarioRespository.SingleAsync(id);
        }

        public async Task UpdateAsync(Usuario entity)
        {
            await _usuarioRespository.UpdateAsync(entity);
        }
    }
}
