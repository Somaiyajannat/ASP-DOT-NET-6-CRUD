using Microsoft.EntityFrameworkCore;
using Relationship.Models;

namespace Relationship.RDbContext
{
    public class WebDbContext:DbContext
    {
        public WebDbContext(DbContextOptions<WebDbContext> Options) : base(Options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Classroom> classrooms { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourses> StudentCourses { get; set; }
    }
}
