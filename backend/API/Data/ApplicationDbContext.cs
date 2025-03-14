using Microsoft.EntityFrameworkCore;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<FondoHistorico> FondoHistorico { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<FondoHistorico>().ToTable("fondohistorico");
        modelBuilder.Entity<FondoHistorico>().HasKey(f => f.FHid); // Configura FHid como la llave primaria
    }
}