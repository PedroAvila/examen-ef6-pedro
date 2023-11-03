using Eamen.Entities;
using FluentValidation;

namespace Examen.Services
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(x => (int)x.PerfilId).InclusiveBetween((int)Perfil.Docente, (int)Perfil.Alumno)
            .WithMessage("El valor del perfil debe ser 1 ó 2");
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("El campo nombre es obligatorio");
            RuleFor(x => x.Apellido).NotEmpty().WithMessage("El campo apellido es obligatorio");
        }
    }
}