using Examen.Contract;
using Examen.Repository;
using Examen.Services;
using Examen.Services.Interface;

namespace Examen.Api
{
    public static class ApplicationServiceExtensions
    {
        public static void AddRegisterService(this IServiceCollection services)
        {
            /*Persistencia*/
            services.AddScoped(typeof(IRepository<>), typeof(BaseRespository<>));
            services.AddScoped<IUsuarioRespository, UsuarioRepository>();
            //services.AddScoped<ILibroRepository, LibroRepository>();

            /*Servicio*/
            services.AddScoped<IUsuarioService, UsuarioService>();
            //services.AddScoped<ILibroService, LibroService>();
        }
    }
}
