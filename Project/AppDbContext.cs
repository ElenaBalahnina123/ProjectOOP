using Microsoft.EntityFrameworkCore;
using ProjectOop.Entities;

public class AppDbContext : DbContext
{

    public DbSet<Article> Articles { get; set; } // артикул
    public DbSet<Subdivision> Divisions { get; set; } // подразделения
    public DbSet<Employee> Employees { get; set; } // сотрудники
    public DbSet<FinishesProductWarehouse> Finishes_product_warehouses { get; set; } // склад готовой продукции
    public DbSet<MaterialCutting> Material_cuttings { get; set; } // материал для раскроя
    public DbSet<Material> Material_for_sketchs { get; set; } // материал для эскиза
    public DbSet<Position> Posts { get; set; } // должность
    public DbSet<Product> Products { get; set; } // товар
    public DbSet<ProductDelivery> Product_Deliverys { get; set; } //поставка товара
    public DbSet<ProductOnWarehouse> Product_in_warehouses { get; set; } // товар на складе
    public DbSet<RawMaterialPuchaseTransaction> Raw_material_puchase_transactions { get; set; } // транзакция закупки сырья
    public DbSet<RawMaterialWarehouse> Raw_material_warehouses { get; set; } // cклад сырья и материалов
    public DbSet<RawMaterialItem> Row_stocks { get; set; }
    public DbSet<Shop> Shops { get; set; } // магазин
    public DbSet<ShopEmployeer> Shop_Emloyeers { get; set; } // сотрудник-магазин
    public DbSet<Sketch> Sketchs { get; set; } //Эскиз
    public DbSet<SketchMaterialization> Sketch_Materializations { get; set; } // Материализация эскиза
    public DbSet<Supplier> Suppliers { get; set; } // Поставщик
    public DbSet<GoodsDelivery> The_goods_deliverys { get; set; } //товар в поставке
    public DbSet<TransactionContents> Transaction_Contentss { get; set; } // Содержимое транзакции
    public DbSet<ResourceRequestHistoryItem> ResourceRequestHistoryItems { get; set; } // История запросов сырья
    public DbSet<ResourceRequestItem> ResourceRequestItems { get; set; } //Содержимое запроса сырья
    public DbSet<ModelColor> Colors { get; set; }

    public AppDbContext()
    {
        Database.EnsureCreated();
    }

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
        modelBuilder.Entity<Article>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<Subdivision>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<Employee>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<FinishesProductWarehouse>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<MaterialCutting>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<Material>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<Position>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<Product>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<ProductDelivery>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<ProductOnWarehouse>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<RawMaterialPuchaseTransaction>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<RawMaterialWarehouse>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<RawMaterialItem>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<Shop>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<ShopEmployeer>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<Sketch>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<SketchMaterialization>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<Supplier>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<GoodsDelivery>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<TransactionContents>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<ResourceRequestHistoryItem>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<ResourceRequestItem>().HasIndex(e => e.ID).IsUnique();
        modelBuilder.Entity<ModelColor>().HasIndex(e => e.ID).IsUnique();
    }
}
