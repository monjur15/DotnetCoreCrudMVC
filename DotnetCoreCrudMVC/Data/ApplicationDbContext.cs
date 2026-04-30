using DotnetCoreCrudMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetCoreCrudMVC.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
               
        }

        public DbSet<Student> Students { get; set; }
        }
}
