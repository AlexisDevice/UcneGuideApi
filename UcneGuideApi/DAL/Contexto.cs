using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using UcneGuideApi.Models;

namespace UcneGuideApi.DAL
{
    public class Contexto : IdentityDbContext<ApplicationUser>
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Materia> Materias { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Sugerencia> Sugerencias { get; set; }
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<UcneGuideApi.Models.Usuario> Usuario { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Materia>().HasData(new List<Materia>()
            {


 new Materia() { MateriaId = 1, Codigo = "HUM-111", Nombre = "Lengua Española y Técnica de Expresión I", Descripcion = "Muy buen", ProfesorId = 1, CarreraId = 1 },
 new Materia() { MateriaId = 2, Codigo = "MAT-125", Nombre = "Precalculo", Descripcion = "Muy buen", ProfesorId = 2, CarreraId = 1 },
 new Materia() { MateriaId = 3, Codigo = "HUM-123", Nombre = "Filosofía", Descripcion = "Muy buen", ProfesorId = 3, CarreraId = 1 },
 new Materia() { MateriaId = 4, Codigo = "QMA-117", Nombre = "Química I", Descripcion = "Muy buen", ProfesorId = 4, CarreraId = 1 },
 new Materia() { MateriaId = 5, Codigo = "QMA-118", Nombre = "Laboratorio de Química I", Descripcion = "Muy buen", ProfesorId = 5, CarreraId = 1 },
 new Materia() { MateriaId = 6, Codigo = "FIS-136", Nombre = "Física I", Descripcion = "Muy buen", ProfesorId = 6, CarreraId = 1 },
 new Materia() { MateriaId = 7, Codigo = "FIS-137", Nombre = "Laboratorio Física I", Descripcion = "Muy buen", ProfesorId = 7, CarreraId = 1 },
 new Materia() { MateriaId = 8, Codigo = "ORI-116", Nombre = "Orientación Académica", Descripcion = "Muy buen", ProfesorId = 8, CarreraId = 1 },

 //Segundo Semestre
 new Materia() { MateriaId = 9, Codigo = "HUM-121", Nombre = "Lengua Española y Técnica de Expresión II", Descripcion = "Muy buen", ProfesorId = 9, CarreraId = 1 },
 new Materia() { MateriaId = 10, Codigo = "FIS-230", Nombre = "Física II", Descripcion = "Muy buen", ProfesorId = 10, CarreraId = 1 },
 new Materia() { MateriaId = 11, Codigo = "FIS-231", Nombre = "Laboratorio Física II", Descripcion = "Muy buen", ProfesorId = 11, CarreraId = 1 },
 new Materia() { MateriaId = 12, Codigo = "MAT-140", Nombre = "Cálculo Diferencial", Descripcion = "Muy buen", ProfesorId = 12, CarreraId = 1 },
 new Materia() { MateriaId = 13, Codigo = "ISC-201", Nombre = "Introducción a la Ingeniería en Sistemas", Descripcion = "Muy buen", ProfesorId = 13, CarreraId = 1 },
 new Materia() { MateriaId = 14, Codigo = "ISC-202", Nombre = "Laboratorio Introducción a la Ingeniería en Sistemas", Descripcion = "Muy buen", ProfesorId = 14, CarreraId = 1 },
 new Materia() { MateriaId = 15, Codigo = "ISC-203", Nombre = "Estructuras Discretas", Descripcion = "Muy buen", ProfesorId = 15, CarreraId = 1 },
 //Tercer Semestre
 new Materia() { MateriaId = 16, Codigo = "ISC-204", Nombre = "Doctrina Social de la Iglesia", Descripcion = "Muy buen", ProfesorId = 16, CarreraId = 1 },
 new Materia() { MateriaId = 17, Codigo = "ISC-205", Nombre = "Calculo Integral", Descripcion = "Muy buen", ProfesorId = 17, CarreraId = 1 },
 new Materia() { MateriaId = 18, Codigo = "MAT-141", Nombre = "Fisica III", Descripcion = "Muy buen", ProfesorId = 18, CarreraId = 1 },
 new Materia() { MateriaId = 19, Codigo = "ISC-206", Nombre = "Laboratorio de Fisica III", Descripcion = "Muy buen", ProfesorId = 19, CarreraId = 1 },
 new Materia() { MateriaId = 20, Codigo = "ISC-207", Nombre = "Tecnica de Programacion", Descripcion = "Muy buen", ProfesorId = 20, CarreraId = 1 },
 new Materia() { MateriaId = 21, Codigo = "ISC-208", Nombre = "Laboratorio de Tecnica de Programacion", Descripcion = "Muy buen", ProfesorId = 21, CarreraId = 1 },
 new Materia() { MateriaId = 22, Codigo = "ISC-209", Nombre = "Actividad Cocurricular", Descripcion = "Muy buen", ProfesorId = 22, CarreraId = 1 },
 new Materia() { MateriaId = 23, Codigo = "ISC-210", Nombre = "Educacion En Valores", Descripcion = "Muy buen", ProfesorId = 23, CarreraId = 1 },
 //Cuarto Semestre
 new Materia() { MateriaId = 24, Codigo = "ISC-211", Nombre = "Metodologia de la Investigacion", Descripcion = "Muy buen", ProfesorId = 24, CarreraId = 1 },
 new Materia() { MateriaId = 25, Codigo = "ISC-212", Nombre = "Contabilidad General", Descripcion = "Muy buen", ProfesorId = 25, CarreraId = 1 },
 new Materia() { MateriaId = 26, Codigo = "ISC-213", Nombre = "Calculo Vectorial", Descripcion = "Muy buen", ProfesorId = 26, CarreraId = 1 },
 new Materia() { MateriaId = 27, Codigo = "ISC-214", Nombre = "Programacion I", Descripcion = "Muy buen", ProfesorId = 27, CarreraId = 1 },
 new Materia() { MateriaId = 28, Codigo = "ISC-215", Nombre = "Laboratorio de Programacion I", Descripcion = "Muy buen", ProfesorId = 28, CarreraId = 1 },
 new Materia() { MateriaId = 29, Codigo = "ISC-216", Nombre = "Estructura de Datos", Descripcion = "Muy buen", ProfesorId = 29, CarreraId = 1 },
 new Materia() { MateriaId = 30, Codigo = "ISC-217", Nombre = "Ecologia y preservacion del medio ambiente", Descripcion = "Muy buen", ProfesorId = 30, CarreraId = 1 },
 //Quinto Semestre
 new Materia() { MateriaId = 31, Codigo = "ISC-218", Nombre = "Algebra Lineal", Descripcion = "Muy buen", ProfesorId = 31, CarreraId = 1 },
 new Materia() { MateriaId = 32, Codigo = "ISC-219", Nombre = "Electronica Aplicada", Descripcion = "Muy buen", ProfesorId = 32, CarreraId = 1 },
 new Materia() { MateriaId = 33, Codigo = "ISC-220", Nombre = "Analisis de sistemas", Descripcion = "Muy buen", ProfesorId = 33, CarreraId = 1 },
 new Materia() { MateriaId = 34, Codigo = "ISC-221", Nombre = "Programacion II", Descripcion = "Muy buen", ProfesorId = 34, CarreraId = 1 },
 new Materia() { MateriaId = 35, Codigo = "ISC-222", Nombre = "Laboratorio de Programacion II", Descripcion = "Muy buen", ProfesorId = 35, CarreraId = 1 },
 new Materia() { MateriaId = 36, Codigo = "ISC-223", Nombre = "Sistemas Operativos", Descripcion = "Muy buen", ProfesorId = 36, CarreraId = 1 },
 new Materia() { MateriaId = 37, Codigo = "ISC-224", Nombre = "Laboratorios Sistemas Operativos", Descripcion = "Muy buen", ProfesorId = 37, CarreraId = 1 },
 new Materia() { MateriaId = 38, Codigo = "ISC-225", Nombre = "Principios de seguridad informatica", Descripcion = "Muy buen", ProfesorId = 38, CarreraId = 1 },
 //Sexto Semestre
 new Materia() { MateriaId = 39, Codigo = "ISC-226", Nombre = "Probabilidad y estadistica", Descripcion = "Muy buen", ProfesorId = 39, CarreraId = 1 },
 new Materia() { MateriaId = 40, Codigo = "ISC-227", Nombre = "Base de Datos I", Descripcion = "Muy buen", ProfesorId = 40, CarreraId = 1 },
 new Materia() { MateriaId = 41, Codigo = "ISC-228", Nombre = "Laboratorio Base de Datos I", Descripcion = "Muy buen", ProfesorId = 41, CarreraId = 1 },
 new Materia() { MateriaId = 42, Codigo = "ISC-229", Nombre = "Arquitectura del Computador", Descripcion = "Muy buen", ProfesorId = 42, CarreraId = 1 },
 new Materia() { MateriaId = 43, Codigo = "ISC-230", Nombre = "Programacion III", Descripcion = "Muy buen", ProfesorId = 43, CarreraId = 1 },
 new Materia() { MateriaId = 44, Codigo = "ISC-231", Nombre = "Laboratorio Programacion III", Descripcion = "Muy buen", ProfesorId = 44, CarreraId = 1 },
 new Materia() { MateriaId = 45, Codigo = "ISC-232", Nombre = "Ecuaciones Diferenciales", Descripcion = "Muy buen", ProfesorId = 45, CarreraId = 1 },
 new Materia() { MateriaId = 46, Codigo = "ISC-233", Nombre = "Diseño de Sistemas", Descripcion = "Muy buen", ProfesorId = 46, CarreraId = 1 },
 //Septimo Semestre
 new Materia() { MateriaId = 47, Codigo = "ISC-234", Nombre = "Proyecto Aplicado", Descripcion = "Muy buen", ProfesorId = 47, CarreraId = 1 },
 new Materia() { MateriaId = 48, Codigo = "ISC-235", Nombre = "Mantenimiento del Hadware", Descripcion = "Muy buen", ProfesorId = 48, CarreraId = 1 },
 new Materia() { MateriaId = 49, Codigo = "ISC-236", Nombre = "Teleproceso y Redes", Descripcion = "Muy buen", ProfesorId = 49, CarreraId = 1 },
 new Materia() { MateriaId = 50, Codigo = "ISC-237", Nombre = "Laboratorio de teleproceso y redes", Descripcion = "Muy buen", ProfesorId = 50, CarreraId = 1 },
 new Materia() { MateriaId = 51, Codigo = "ISC-238", Nombre = "Programacion Aplicada I", Descripcion = "Muy buen", ProfesorId = 51, CarreraId = 1 },
 new Materia() { MateriaId = 52, Codigo = "ISC-239", Nombre = "Laboratorio Programacion Aplicada I", Descripcion = "Muy buen", ProfesorId = 52, CarreraId = 1 },
 new Materia() { MateriaId = 53, Codigo = "ISC-241", Nombre = "Pasantia I", Descripcion = "Muy buen", ProfesorId = 53, CarreraId = 1 },
 new Materia() { MateriaId = 54, Codigo = "ISC-242", Nombre = "Ingenieria Econimica", Descripcion = "Muy buen", ProfesorId = 53, CarreraId = 1 },
 new Materia() { MateriaId = 55, Codigo = "ISC-243", Nombre = "Organizacion y Administracion de sistemas", Descripcion = "Muy buen", ProfesorId = 53, CarreraId = 1 },
 new Materia() { MateriaId = 56, Codigo = "ISC-244", Nombre = "Base de Datos II", Descripcion = "Muy buen", ProfesorId = 53, CarreraId = 1 },
 new Materia() { MateriaId = 57, Codigo = "ISC-245", Nombre = "laboratorio de Base de Datos II", Descripcion = "Muy buen", ProfesorId = 53, CarreraId = 1 },
 new Materia() { MateriaId = 58, Codigo = "ISC-246", Nombre = "Programacion Aplicada I", Descripcion = "Muy buen", ProfesorId = 53, CarreraId = 1 },
 new Materia() { MateriaId = 59, Codigo = "ISC-247", Nombre = "Computacion Centrada en Redes", Descripcion = "Muy buen", ProfesorId = 53, CarreraId = 1 },
 new Materia() { MateriaId = 60, Codigo = "ISC-248", Nombre = "Simulacion Digital", Descripcion = "Muy buen", ProfesorId = 53, CarreraId = 1 },








            });




        // base.OnModelCreating(builder); // Importante para Identity

        // Configurar relaciones si es necesario
        //builder.Entity<Sugerencia>()
        // .HasOne(s => s.UsuarioId)
        //  .WithMany()
        // .HasForeignKey(s => s.UsuarioId)
        // .OnDelete(DeleteBehavior.Cascade);

        // builder.Entity<Comentario>()
        //.HasOne(c => c.UsuarioId)
        // .WithMany()
        // .HasForeignKey(c => c.UsuarioId)
        // .OnDelete(DeleteBehavior.Cascade);
    }
       
    }
}
