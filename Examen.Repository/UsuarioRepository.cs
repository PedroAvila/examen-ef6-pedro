using Eamen.Entities;
using Examen.Contract;

namespace Examen.Repository
{
    public class UsuarioRepository : BaseRespository<Usuario>, IUsuarioRespository
    {
        private readonly BibliotecaContext _context;

        public UsuarioRepository(BibliotecaContext context): base(context) 
        {
            _context = context;
        }
    }
}
