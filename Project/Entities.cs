using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOop
{
    namespace Entities // сущности
    {
        public enum Role
        {
            Директор, // директор, может всё
            Швея, // швея, стадия пошива
            Раскройщик, // раскройщик, стадия раскроя
            Дизайнер, // модельек, стадии художественного и технологического эскизов
            Технолог // технолог, контроль качества
        }
        public enum WearSize
        {
            XS,
            S,
            M,
            L,
            XL
        }


        public class Employee // сотрудник
        {
            public int ID { get; set; }
          
            [Required] [MaxLength(50)] public string Name { get; set; } // фамилия 
            [Required] [MaxLength(50)] public string Surname { get; set; } // имя
            [MaxLength(50)] public string Patronymic { get; set; } // отчество
            [Required] public DateTime DeviceDate { get; set; } // дата устройства
            [Required] public string Salary { get; set; } //оклад
            [Required] public string Login { get; set; }
            [Required] public string Password { get; set; }
            [Required] public Role Role { get; set; }
        }

        public class Material // материал
        {
            public int ID { get; set; }
            [Required] public string Name { get; set; }

            public ModelColor color { get; set; }


        }

        public class ModelColor
        {
            public int ID { get; set; }
            [Required] public string RgbValue { get; set; }
            [Required] public string TextName { get; set; }


        }

        public class Sketch
        {
            public int ID { get; set; }
            [Required] public string Name { get; set; }


            [Required] public string FileLocation { get; set; }

            [Required] public Employee Author { get; set; }

            [Required] public DateTime CreationDate { get; set; }
        }

        public class Blueprint
        {
            public int ID { get; set; }

            [Required] public WearSize Size { get; set; }

            public List<MaterialInBlueprint> Materials { get; set; }

            [Required] public DateTime CreationDate { get; set; }

        }



        public class MaterialInBlueprint
        {
            public int ID { get; set; }

            public Blueprint Blueprint;

            public Material material;
        }

        public class Cut
        {
            public int ID { get; set; }

            [Required] public Employee Author { get; set; }

            [Required] public DateTime CreationDate { get; set; }
        }

        public class Sewing
        {
            public int ID { get; set; }

            [Required] public Employee Author { get; set; }

            [Required] public DateTime CreationDate { get; set; }
        }

        public class Product
        {
            public int ID { get; set; }

            public Sketch Sketch { get; set; }

            public Blueprint Blueprint { get; set; }

            public Cut Cut { get; set; }

            public Sewing Sewing { get; set; }

            public bool QaPassed { get; set; }

        }

        public enum Stage
        {
            INITIAL,
            SKETCH,
            BLUEPRINT,
            CUT,
            SEWING,
            READY
        }

        public static class ProductExtension
        {
            /// <summary>
            /// Продукт должен быть загружен вместе со связанными сущностями
            /// 
            /// https://docs.microsoft.com/ru-ru/ef/ef6/querying/related-data
            /// </summary>
            /// <param name="product"></param>
            /// <returns></returns>
            public static Stage GetStage(this Product product)
            {
                if (product.Sketch == null) return Stage.INITIAL;
                // sketch != null
                else if (product.Blueprint == null) return Stage.SKETCH;
                // blueprint != null
                else if (product.Cut == null) return Stage.BLUEPRINT;
                // cut != null
                else if (product.Sewing == null) return Stage.CUT;
                // sewing != null
                else if (!product.QaPassed) return Stage.SEWING;
                else return Stage.READY;
            }

            public static async Task RemoveFromDb(this Product initialProduct, AppDbContext db)
            {
                var product = await db.Products
                    .Where(p => p.ID == initialProduct.ID)
                    .Include(p => p.Sketch)
                    .Include(p => p.Blueprint.Materials)
                    .Include(p => p.Cut)
                    .Include(p => p.Sewing)
                    .FirstOrDefaultAsync();

                if (product.Sketch != null)
                {
                    db.Remove(product.Sketch);
                }
                if (product.Blueprint != null)
                {
                    foreach (MaterialInBlueprint m in product.Blueprint.Materials)
                    {
                        db.Remove(m);
                    }

                    db.Remove(product.Blueprint);
                }
                if (product.Cut != null)
                {
                    db.Remove(product.Cut);
                }
                if (product.Sewing != null)
                {
                    db.Remove(product.Sewing);
                }
                db.Remove(product);

                db.SaveChanges();
            }
        }
    }
}
