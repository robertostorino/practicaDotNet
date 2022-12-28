using Microsoft.EntityFrameworkCore;
using universityApiBackend.Models.DataModels;

namespace universityApiBackend.DataAccess
{
    public class UniversityDBContext: DbContext
    {
        //  Constructor
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options): base(options)
        {

        }

        //  TODO: Add DbSets (Tables of our Data Base)

        //  Crea tablas dentro de mi BD como se ha especificado en mi appsettings.
        //Users serà el nombre de la tabla
        public DbSet<User>? Users { get; set; }

        //Courses será el nombre de la tabla
        public DbSet<Curso>? Cursos { get; set; } 
    }
}
