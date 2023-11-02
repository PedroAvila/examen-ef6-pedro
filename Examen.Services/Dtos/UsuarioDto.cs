using Eamen.Entities;

namespace Examen.Services.Dtos
{
    public class UsuarioDto
    {
        public Perfil PerfilId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public int Estado { get; set; }

        public static Usuario ToEntity(UsuarioDto dto) =>
            new Usuario
            {
                PerfilId = dto.PerfilId,
                Nombre = dto.Nombre,
                Apellido = dto.Apellido,
                Email = dto.Email,
                Telefono = dto.Telefono,
                Estado = dto.Estado == 1 ? EstadoUsuario.Habilitado : EstadoUsuario.Sancionado
            };
    }
}
