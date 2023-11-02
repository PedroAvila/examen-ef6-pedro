using Eamen.Entities;
using Examen.Contract;

namespace Examen.Repository
{
    public class LibroRepository: BaseRespository<Libro>, ILibroRepository
    {
        private readonly BibliotecaContext _context;

        public LibroRepository(BibliotecaContext context): base(context) 
        {
            _context = context;
        }
    }
}
