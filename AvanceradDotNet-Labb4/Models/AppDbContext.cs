using Microsoft.EntityFrameworkCore;

namespace AvanceradDotNet_Labb4.Models
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<PersonInterest> PersonInterests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>().
                HasData(new Person 
                { 
                    PersonId = 1,
                    Name = "Sara Henriksson",
                    Phone = 0735349253,
                    Email = "Sara73@gmail.com"
                });
            modelBuilder.Entity<Person>().
                HasData(new Person
                {
                    PersonId = 2,
                    Name = "Karl Bengtsson",
                    Phone = 0730569349,
                    Email = "KalleB@gmail.com"
                });
            modelBuilder.Entity<Person>().
                HasData(new Person
                {
                    PersonId = 3,
                    Name = "Jonas Fältgren",
                    Phone = 0745560443,
                    Email = "JonasFaltgren@gmail.com"
                });
            modelBuilder.Entity<Interest>().
                HasData(new Interest
                {
                    InterestId=1,
                    Name="Fotboll",
                    Description = "En sport där man sparkar på en boll för att göra mål"
                });
            modelBuilder.Entity<Interest>().
                HasData(new Interest
                {
                    InterestId = 2,
                    Name = "Basket",
                    Description = "En sport där man studsar en boll och ska kasta den i en korg"
                });
            modelBuilder.Entity<Interest>().
                HasData(new Interest
                {
                    InterestId = 3,
                    Name = "Hästridning",
                    Description = "Man rider runt på en häst"
                });
            modelBuilder.Entity<Interest>().
                HasData(new Interest
                {
                    InterestId = 4,
                    Name = "Måla",
                    Description = "Måla tavlor mm."
                });
            modelBuilder.Entity<Interest>().
                HasData(new Interest
                {
                    InterestId = 5,
                    Name = "Brädspel",
                    Description = "Spela brädspel med andra"
                });


        }
    }
}
