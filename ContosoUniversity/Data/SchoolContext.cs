using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
  public class SchoolContext : DbContext
  {
    public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
    {
    }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Enrollment> Enrollment { get; set; }
    public DbSet<Student> Students { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Course>().ToTable("Course");
      modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
      modelBuilder.Entity<Student>().ToTable("Student");
      // overrides the default Entity migration which is to pluralize table name
    }
  }
}