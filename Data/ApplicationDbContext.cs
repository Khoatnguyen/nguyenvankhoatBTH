using NGUYENVANKHOATBTH2.Models;
using Microsoft.EntityFrameworkCore;

namespace NGUYENVANKHOATBTH2.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student>Students {get;set;}
        public DbSet<NGUYENVANKHOATBTH2.Models.Employee>? Employee { get; set; }
        public DbSet<NGUYENVANKHOATBTH2.Models.Person>? Person { get; set; }
        public DbSet<NGUYENVANKHOATBTH2.Models.Customer>? Customer { get; set; }
         public DbSet<NGUYENVANKHOATBTH2.Models.Faculty>? Faculty { get; set; }
    }

}