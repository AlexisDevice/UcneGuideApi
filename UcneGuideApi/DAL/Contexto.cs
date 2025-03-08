using Microsoft.EntityFrameworkCore;
using UcneGuideApi.Models;

namespace UcneGuideApi.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Materia> Materias { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Sugerencia> Sugerencias { get; set; }
    }
}
