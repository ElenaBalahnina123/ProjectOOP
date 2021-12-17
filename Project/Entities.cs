using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectOop
{
    namespace Entities
    {
        public class Article
        {
            public int ID { get; set; }
        }

        public class ResourceRequestHistoryItem
        {
            public int ID { get; set; }
            [Required] public DateTime Date { get; set; }
            public RawMaterialWarehouse Warehouse { get; set; }
        }

        public class ResourceRequestItem
        {
            public int ID { get; set; }

            public int Quantity { get; set; }

            public Article Article { get; set; }

            public ResourceRequestHistoryItem Request { get; set; }

 
        }

        public class GoodsDelivery
        {
            public int ID { get; set; }

            public Product Product { get; set; }
            public ProductDelivery ProductDelivery { get; set; }
            public FinishesProductWarehouse FinishesProductWarehouse { get; set; }

            public int Quantity { get; set; }
            [Required] [MaxLength(15)] public string Size { get; set; }
            [Required] public string Color { get; set; }
        }

        public class ShopEmployeer
        {
            public int ID { get; set; }
            public Shop Shop{ get; set; }
        }

        public class Post
        {
            public int ID { get; set; }
            [Required] public string NamePost { get; set; }

        }

        public class RawMaterialWarehouse
        {
            public int ID { get; set; }
        }

        public class RawMaterialItem
        {
            public int ID { get; set; }
            public RawMaterialWarehouse Warehouse { get; set; }
            public Article Article { get; set; }
            public int Quantity { get; set; }
        }

        public class Subdivision 
        {
            public int ID { get; set; }
            [Required] public string Name { get; set; }
        }

        public class Employee
        {
            public int ID { get; set; }
            [Required] [MaxLength(50)] public string LastName { get; set; }
            [Required] [MaxLength(50)] public string FirstName { get; set; }
            [MaxLength(50)] public string MiddleName { get; set; }

            [Required] public DateTime DeviceDate { get; set; }
            [Required] public decimal Salary { get; set; }

            public Post post { get; set; }
        }

        public class FinishesProductWarehouse
        {
            public int ID { get; set; }
        }

        public class MaterialCutting
        {

            public int ID { get; set; }
            public MaterialForSketch MaterialForSketch { get; set; }
            public SketchMaterialization SketchMaterialization { get; set; }
            public int Quantity { get; set; }
        }

        public class MaterialForSketch
        {
            public int ID { get; set; }
            public Article Article { get; set; }
            public Sketch Sketch { get; set; }

        }
        public class Product
        {
            public int ID { get; set; }
            public SketchMaterialization SketchMaterialization { get; set; }
        }
        public class ProductDelivery
        {
            public int ID { get; set; }
            public Shop Shop { get; set; }
            [Required] public DateTime DeliveryDate { get; set; }
        }
        public class ProductInWarehouse
        {
            public int ID { get; set; }

            public FinishesProductWarehouse FinishesProductWarehouse { get; set; }
            public Product Product { get; set; }
            public int Quantity { get; set; }
            [Required] [MaxLength(15)] public string Size { get; set; }
            [Required] public string Color { get; set; }
        }
        public class RawMaterialPuchaseTransaction
        {
            public int ID { get; set; }
            [Required] public DateTime PurchaseDate { get; set; }
            public Employee Employee { get; set; }
            public Supplier Supplier { get; set; }
            public RawMaterialWarehouse RawMaterialWarehouse { get; set; }

        }
        public class Shop
        {
            public int ID { get; set; }
            [Required] public string ShopName { get; set; }
            [Required] public string Address { get; set; }
        }
        public class Sketch
        {
            public int ID { get; set; }
            [Required] [MaxLength(50)] public string Name { get; set; }
            public Employee Employee { get; set; }
            [Required] public DateTime CreationDate { get; set; }
            [Required] [MaxLength(70)] public string DegreeDevelopment { get; set; }
        }
        public class SketchMaterialization
        {
            public int ID { get; set; }
            [Required] [MaxLength(15)] public string Size { get; set; }
            public Article Article { get; set; }
            public Employee Employee { get; set; }

            [Required] public DateTime CreationDate { get; set; }
            [Required] public string DegreeDevelopment { get; set; }
        }
        public class Supplier
        {
            public int ID { get; set; }
            [Required] public string NameOrganization { get; set; }

        }

        public class TransactionContents
        {
            public int ID { get; set; }
            public RawMaterialPuchaseTransaction RawMaterialPuchaseTransaction { get; set; }
            public Article Article { get; set; }
            [Required] public int Quantity { get; set; }
            [Required] public decimal Price { get; set; }
            [Required] public int INN { get; set; }
        }

        public class ModelColor
        {
            public int ID { get; set; }
            public string RgbValue { get; set; }
            public string TextName { get; set; }
        }
    }
}
