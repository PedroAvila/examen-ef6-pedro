namespace Examen.Services.Dtos
{
    public class LibroDto
    {
        public string? ISBN { get; set; }
        public string? Nombre { get; set; }
        public int CategoriaId { get; set; }
        public string? Autor { get; set; }
        public string? Pais { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string? Editorial { get; set; }
    }
}
