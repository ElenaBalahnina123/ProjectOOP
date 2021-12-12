using Microsoft.EntityFrameworkCore;
using ProjectOop.Entities;

public class AppDbContext : DbContext
{

    public DbSet<Article> Articles { get; set; }
    public DbSet<Division> Divisions { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<FinishesProductWarehouse> Finishes_product_warehouses { get; set; }
    public DbSet<MaterialCutting> Material_cuttings { get; set; }
    public DbSet<MaterialForSketch> Material_for_sketchs { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductDelivery> Product_Deliverys { get; set; }
    public DbSet<ProductInWarehouse> Product_in_warehouses { get; set; }
    public DbSet<RawMaterialPuchaseTransaction> Raw_material_puchase_transactions { get; set; }
    public DbSet<RawMaterialWarehouse> Raw_material_warehouses { get; set; }
    public DbSet<RawMaterialItem> Row_stocks { get; set; }
    public DbSet<Shop> Shops { get; set; }
    public DbSet<ShopEmployeer> Shop_Emloyeers { get; set; }
    public DbSet<Sketch> Sketchs { get; set; }
    public DbSet<SketchMaterialization> Sketch_Materializations { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<GoodsDelivery> The_goods_deliverys { get; set; }
    public DbSet<TransactionContents> Transaction_Contentss { get; set; }
    public DbSet<ResourceRequestHistoryItem> ResourceRequestHistoryItems { get; set; }
    public DbSet<ResourceRequestItem> ResourceRequestItems { get; set; }


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
}
