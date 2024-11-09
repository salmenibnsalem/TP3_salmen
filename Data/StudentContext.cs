using Microsoft.EntityFrameworkCore;
using TP3_salmen.Models;
namespace TP3_salmen.Data

{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }
    }
}
