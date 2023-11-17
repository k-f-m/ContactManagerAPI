using Microsoft.EntityFrameworkCore;

namespace ContactManagerAPI.Models
{
    // we use the Entity Framework Core to create a session with the
    // database for querying and storing instances of entities
    public class ContactManagerDbContext : DbContext
    {
        public ContactManagerDbContext(DbContextOptions<ContactManagerDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}