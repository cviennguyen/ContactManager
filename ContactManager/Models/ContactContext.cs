using Microsoft.EntityFrameworkCore;

namespace ContactManager.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options) { }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categoriy { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Family" },
                new Category { CategoryId = 2, Name = "Friend" },
                new Category { CategoryId = 3, Name = "Work" },
                new Category { CategoryId = 4, Name = "Other" }
                );
            modelBuilder.Entity<Contact>().HasData(
            new Contact
            {
                ContactId = 1,
                Firstname = "Frodo",
                Lastname = "Baggings",
                Phone = "416-123-1233",
                Email = "frodo@gomain.ca",
                CategoryID = 1,
                DateAdded = DateTime.Now
            },
            new Contact
            {
                ContactId = 2,
                Firstname = "FPI",
                Lastname = "Baggings",
                Phone = "416-123-1233",
                Email = "frodo@gomain.ca",
                CategoryID = 1,
                DateAdded = DateTime.Now
            },
            new Contact
            {
                ContactId = 3,
                Firstname = "ABC",
                Lastname = "Baggings",
                Phone = "416-123-1233",
                Email = "frodo@gomain.ca",
                CategoryID = 2,
                DateAdded = DateTime.Now
            },
            new Contact
            {
                ContactId = 4,
                Firstname = "CFH",
                Lastname = "Baggings",
                Phone = "416-123-1233",
                Email = "frodo@gomain.ca",
                CategoryID = 3,
                DateAdded = DateTime.Now
            });

        }
    }
        
}
