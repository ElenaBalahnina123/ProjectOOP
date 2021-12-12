using System;

public class AppContext
{

    public DbSet<Article> Articles { get; set; }
    public DbSet<Defect> Defects { get; set; }
    public DbSet<Division> Divisions { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Finishes_product_warehouse> Finishes_product_warehouses { get; set; }
    public DbSet<Material_cutting> Material_cuttings { get; set; }
    public DbSet<Material_for_sketch> Material_for_sketchs { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Product_Delivery> Product_Deliverys { get; set; }
    public DbSet<Product_in_warehouse> Product_in_warehouses { get; set; }
    public DbSet<Raw_material_puchase_transaction> Raw_material_puchase_transactions { get; set; }
    public DbSet<Raw_material_warehouse> Raw_material_warehouses { get; set; }
    public DbSet<Row_stock> Row_stocks { get; set; }
    public DbSet<Shop> Shops { get; set; }
    public DbSet<Shop_Emloyeer> Shop_Emloyeers { get; set; }
    public DbSet<Sketch> Sketchs { get; set; }
    public DbSet<Sketch_Materialization> Sketch_Materializations { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<The_goods_delivery> The_goods_deliverys { get; set; }
    public DbSet<Transaction_Contents> Transaction_Contentss { get; set; }


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
        var password = "";
        optionsBuilder.UseNpgsql($"Host={host};Port={port};Database={databaseName};Username={username};Password={password}");
    }
}
