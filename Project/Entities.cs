using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProjectOop
{
    namespace Entities // сущности
    {
        public class Article // артикул
        {
            public int ID { get; set; }
        }

        public class ResourceRequestHistoryItem // История запросов сырья
        {
            public int ID { get; set; }
            [Required] public DateTime Date { get; set; } // дата
            public RawMaterialWarehouse Warehouse { get; set; } // ID склада
        }

        public class ResourceRequestItem // содержимое запроса сырья
        {
            public int ID { get; set; }

            public int Quantity { get; set; } // количество

            public Article Article { get; set; } //ID артикула

            public ResourceRequestHistoryItem Request { get; set; } //ID запроса

        }

        public class GoodsDelivery // Товар в поставке
        {
            public int ID { get; set; }
            public Product Product { get; set; } //ID товара
            public ProductDelivery ProductDelivery { get; set; } // ID поставки товара
            public FinishesProductWarehouse FinishesProductWarehouse { get; set; } // ID склада готовой продукции
            public int Quantity { get; set; } // количество
            [Required] [MaxLength(15)] public string Size { get; set; } // размер
            public ModelColor Color { get; set; } // цвет
        }

        public class ShopEmployeer // сотрудник-магазин
        {
            public int ID { get; set; }
            public Shop Shop{ get; set; } //ID магазина
        }

        public class Position //должность
        {
            public int ID { get; set; }
            [Required] public string Name { get; set; } // название

            public List<Role> Roles { get; set; }
        }

        public class Role
        {
            public int ID { get; set; }
            [Required] public string Name { get; set; } // название
        }

        public class RawMaterialWarehouse // cклад сырья и материалов
        {
            public int ID { get; set; }
        }

        public class RawMaterialItem // Сырье на складе
        {
            public int ID { get; set; }
            public RawMaterialWarehouse Warehouse { get; set; }
            public Article Article { get; set; }
            public int Quantity { get; set; }
        }

        public class Subdivision // подразделения
        {
            public int ID { get; set; }
            [Required] public string Name { get; set; }
        }

        public class Employee // сотрудник
        {
            public int ID { get; set; }
            public string Login { get; set; }
            public string Password { get; set; }
            [Required] [MaxLength(50)] public string LastName { get; set; } // фамилия 
            [Required] [MaxLength(50)] public string FirstName { get; set; } // имя
            [MaxLength(50)] public string MiddleName { get; set; } // отчество
            [Required] public DateTime DeviceDate { get; set; } // дата устройства
            [Required] public string Salary { get; set; } //оклад
            public Position post { get; set; } // должность
        }

        public class FinishesProductWarehouse // склад готовой продукции 
        {
            public int ID { get; set; }
        }

        public class MaterialCutting // материал для райскроя
        {
            public int ID { get; set; }
            public Material MaterialForSketch { get; set; } // материал для эскиза
            public SketchMaterialization SketchMaterialization { get; set; } // мтериализация эскиза
            public int Quantity { get; set; } // количество
        }

        public class Material // материал
        {
            public int ID { get; set; }
            public Article Article { get; set; }
            public string Name { get; set; }

        }

        public class Product // товар
        {
            public int ID { get; set; }
            public SketchMaterialization SketchMaterialization { get; set; }
        } 

        public class ProductDelivery // поставка товара
        {
            public int ID { get; set; }
            public Shop Shop { get; set; }
            [Required] public DateTime DeliveryDate { get; set; }
        } 

        public class ProductOnWarehouse // товар на складе
        {
            public int ID { get; set; }
            public FinishesProductWarehouse FinishesProductWarehouse { get; set; } // ID склада
            public Product Product { get; set; }
            public int Quantity { get; set; }
            [Required] public int Size { get; set; }
            public ModelColor Color { get; set; }
        }

        public class RawMaterialPuchaseTransaction // Транзакция закупки сырья
        {
            public int ID { get; set; }
            [Required] public DateTime PurchaseDate { get; set; } //дата покупки
            public Employee Employee { get; set; } // ID сотрудника
            public Supplier Supplier { get; set; } // ID поставщика
            public RawMaterialWarehouse RawMaterialWarehouse { get; set; } //ID склада
        }

        public class Shop // магазин
        {
            public int ID { get; set; }
            [Required] public string ShopName { get; set; }
            [Required] public string Address { get; set; }
        }

        public class Sketch //эскиз
        {
            public int ID { get; set; }
            [Required] [MaxLength(50)] public string Name { get; set; }
            public Employee Employee { get; set; } // сотрудник
            [Required] public DateTime CreationDate { get; set; } // дата создания эскиза
            [Required] [MaxLength(70)] public string DegreeDevelopment { get; set; } //степень разработки
        } 

        public class SketchMaterialization //Материализация эскиза
        {
            public int ID { get; set; }
            [Required] [MaxLength(15)] public string Size { get; set; }
            public Article Article { get; set; }
            public Employee Employee { get; set; }
            [Required] public DateTime CreationDate { get; set; } // дата создания
            [Required] public string DegreeDevelopment { get; set; } // степень разработки
        } 

        public class Supplier// поставщик
        {
            public int ID { get; set; }
            [Required] public string NameOrganization { get; set; }
            [Required] public int INN { get; set; }

        } 

        public class TransactionContents //Содержимое транзакции 
        {
            public int ID { get; set; }
            public RawMaterialPuchaseTransaction RawMaterialPuchaseTransaction { get; set; }
            public Article Article { get; set; }
            [Required] public int Quantity { get; set; }
            [Required] public double Price { get; set; }
        }

        public class ModelColor
        {
            public int ID { get; set; }
            public string RgbValue { get; set; }
            public string TextName { get; set; }
        }
    }
}
