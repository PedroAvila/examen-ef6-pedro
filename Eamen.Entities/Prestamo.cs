namespace Eamen.Entities
{
    public class Prestamo
    {
        public int PrestamoId { get; set; }
        public int UsuarioId { get; set; }
        public int LibroId { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public EstadoPrestamo Estado { get; set; }

        public virtual Usuario? Usuario { get; set; }
        public virtual Libro? Libro { get; set; }
    }
}
