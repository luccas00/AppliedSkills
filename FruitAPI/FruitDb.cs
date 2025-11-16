using Microsoft.EntityFrameworkCore;

class FruitDb : DbContext
{
    public FruitDb(DbContextOptions<FruitDb> options)
        : base(options) { }

    public DbSet<Fruit> Fruits => Set<Fruit>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Fruit>()
            .HasData(
            new Fruit { Id = 1, Name = "Apple", Instock = true },
            new Fruit { Id = 2, Name = "Banana", Instock = false },
            new Fruit { Id = 3, Name = "Orange", Instock = true },
            new Fruit { Id = 4, Name = "Grape", Instock = true },
            new Fruit { Id = 5, Name = "Mango", Instock = false },
            new Fruit { Id = 6, Name = "Pineapple", Instock = true },
            new Fruit { Id = 7, Name = "Strawberry", Instock = true }
            );
    }
}