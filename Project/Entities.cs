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
            // ид склада
        }

        public class ResourceRequestItem
        {
            public int ID { get; set; }

            public int Quantity { get; set; }
            // ид запроса, артикула
        }

        public class GoodsDelivery
        {
            public int ID { get; set; }
            // ид товара, поствки товара, склада готовой продукции
            public int Quantity { get; set; }
            [Required] [MaxLength(15)] public string Size { get; set; }
            [Required] public string Color { get; set; }
        }

        public class ShopEmployeer
        {
            public int ID { get; set; }
            // ид магазина
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

            public Article article { get; set; }

            //ид склада, артикула
            public int Quantity { get; set; }
        }

        public class Division //подразделение
        {
            public int ID { get; set; }
            [Required] public string NamePost { get; set; }
        }

        public class Employee
        {
            public int ID { get; set; }
            [Required] [MaxLength(50)] public string LastName { get; set; }
            [Required] [MaxLength(50)] public string FirstName { get; set; }
            [MaxLength(50)] public string MiddleName { get; set; }

            [Required] public DateTime DeviceDate { get; set; }
            [Required] [Column(TypeName = "money")] public decimal Salary { get; set; }

            public Post post { get; set; }
        }

        public class FinishesProductWarehouse
        {
            public int ID { get; set; }
        }

        public class MaterialCutting
        {

            public int ID { get; set; }
            // ид материализации, материала для эскиза
            public int Quantity { get; set; }
        }

        public class MaterialForSketch
        {
            public int ID { get; set; }
            //ид артикула, эскиза
        }
        public class Product
        {
            public int ID { get; set; }
            // ид материализации
        }
        public class ProductDelivery
        {
            public int ID { get; set; }
            // ид магазина
            [Required] public DateTime DeliveryDate { get; set; }
        }
        public class ProductInWarehouse
        {
            public int ID { get; set; }
            // ид товара, склада
            public int Quantity { get; set; }
            [Required] [MaxLength(15)] public string Size { get; set; }
            [Required] public string Color { get; set; }
        }
        public class RawMaterialPuchaseTransaction
        {
            public int ID { get; set; }
            [Required] public DateTime PurchaseDate { get; set; }

            //ид поставщика, склада, сотрудника
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
            //id сотрудника
            [Required] public DateTime CreationDate { get; set; }
            [Required] [MaxLength(70)] public string DegreeDevelopment { get; set; }
        }
        public class SketchMaterialization
        {
            public int ID { get; set; }
            [Required] [MaxLength(15)] public string Size { get; set; }
            // ид артикула, сотрудника

            public Employee employee { get; set; }

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
            // id транзакции
            // ид артикула
            [Required] public int Quantity { get; set; }
            [Required] public decimal Price { get; set; }
            [Required] public int INN { get; set; }
        }
    }
}
