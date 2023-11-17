using Microsoft.EntityFrameworkCore;

namespace ContactManagerAPI.Models
{
    /// <summary>
    /// Create a session with the database for querying and storing instances of entities.
    /// </summary>
    public class ContactManagerDbContext : DbContext
    {
        public ContactManagerDbContext(DbContextOptions<ContactManagerDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}