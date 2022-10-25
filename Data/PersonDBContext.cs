using Microsoft.EntityFrameworkCore;
using WebSecurityXSS.Models;

namespace WebSecurityXSS.Data
{
    public class PersonDBContext : DbContext 
    {
        //public PersonDBContext(DbContextOptions<PersonDBContext> options):base(options)
        //{

        //}
        public DbSet<Person> persons { get; set; }   
    }
}
