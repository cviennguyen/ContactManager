using Microsoft.EntityFrameworkCore;

namespace ContactManager.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options) {}
        public DbSet<Contact> Contacts { get; set;}
        public DbSet<Category> Categoriy { get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Family" },
                new Category { CategoryId = 2, Name = "Friend" },
                new Category { CategoryId = 3, Name = "Work" },
                new Category { CategoryId = 4, Name = "Other" }
                );
        }
    }
}
