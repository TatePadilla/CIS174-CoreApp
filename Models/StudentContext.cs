using CIS174_CoreApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CIS174_CoreApp.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        { }
        public DbSet<Student> Students { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, FirstName = "Alice", LastName = "Johnson", Grade = "A" },
                new Student { StudentId = 2, FirstName = "Bob", LastName = "Smith", Grade = "B" },
                new Student { StudentId = 3, FirstName = "Carl", LastName = "Brown", Grade = "C" },
                new Student { StudentId = 4, FirstName = "Dan", LastName = "White", Grade = "D" }
            );
        }
    }
}
