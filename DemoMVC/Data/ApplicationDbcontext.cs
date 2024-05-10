using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;
namespace DemoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
    public DbSet<Person> Person {get; set;}
    public DbSet<Employee> Employee {get; set;}
    public DbSet<Employee> Student {get; set;}
        public DbSet<DemoMVC.Models.Student> Student_1 { get; set; } = default!;


    }
}
