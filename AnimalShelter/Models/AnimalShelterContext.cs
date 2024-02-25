using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Frederik", Species = "Dog"},
          new Animal { AnimalId = 2, Name = "Nicolai", Species = "Cat"},
          new Animal { AnimalId = 3, Name = "Wolfram", Species = "Dog"},
          new Animal { AnimalId = 4, Name = "Yevgeny", Species = "Cat"},
          new Animal { AnimalId = 5, Name = "Milosz", Species = "Dog"}
        );
    }
  }
}