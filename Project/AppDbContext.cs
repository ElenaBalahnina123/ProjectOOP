using Microsoft.EntityFrameworkCore;
using ProjectOop.Entities;
using System.Threading.Tasks;

public class AppDbContext : DbContext
{

    /// <summary>
    /// Запросы в базу данных
    /// </summary>
    public DbSet<Employee> Employees { get; set; }
    public DbSet<ModelColor> Colors { get; set; }
    public DbSet<Sketch> Sketches { get; set; }
    public DbSet<Blueprint> Blueprints { get; set; }
    public DbSet<Cut> Cuts { get; set; }
    public DbSet<Sewing> Sewings { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Material> Materials { get; set; }
    public DbSet<MaterialInBlueprint> MaterialInBlueprints { get; set; }


    /// <summary>
    /// Гарантирует, что база данных для контекста существует.
    /// Если он существует, никаких действий не предпринимается.
    /// Если он не существует, создается база данных и вся ее схема. 
    /// Если база данных существует, то не предпринимается никаких усилий 
    /// для обеспечения ее совместимости с моделью для этого контекста.
    /// </summary>
    public AppDbContext()
    {    
        Database.EnsureCreated();
    }

    /// <summary>
    /// Метод для настройки базы данных и других параметров, которые будут использоваться в контексте
    /// </summary>
    /// <param name="optionsBuilder"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var host = "127.0.0.1";
        var port = "5432";
        var databaseName = "ProjectOOP";
        var username = "postgres";
        var password = "1234";
        optionsBuilder.UseNpgsql($"Host={host};Port={port};Database={databaseName};Username={username};Password={password}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<ModelColor>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<Material>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<Sketch>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<Blueprint>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<Cut>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<Sewing>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<Product>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<MaterialInBlueprint>().HasIndex(e => e.ID).IsUnique();
    }
}
