using Eamen.Entities;
using Microsoft.EntityFrameworkCore;

namespace Examen.Repository
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options) { }


        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<Libro>? Libros { get; set; }
        public DbSet<Prestamo>? Prestamos { get; set; }
    }
}
