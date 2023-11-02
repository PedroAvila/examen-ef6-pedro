namespace Eamen.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public Perfil PerfilId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public EstadoUsuario Estado { get; set; }

        public virtual List<Prestamo>? Prestamos { get; set; }
    }
}
