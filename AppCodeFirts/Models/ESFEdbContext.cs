using Microsoft.EntityFrameworkCore;

namespace AppCodeFirts.Models
{
    public class ESFEdbContext:DbContext
    {
        public ESFEdbContext(DbContextOptions<ESFEdbContext> options) : base(options) { }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Alumno> Alumnos {  get; set; }
    }
}
