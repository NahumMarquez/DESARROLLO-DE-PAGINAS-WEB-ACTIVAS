using Microsoft.EntityFrameworkCore;
using PROYECTO1.Models;
using TAREA1.Models;

namespace TAREA1.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Alumnos> Alumnos { get; set; }
    }
}
