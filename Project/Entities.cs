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

        //Перечисление
        public enum Role
        {
            DIRECTOR, //может всё
            SEWER, //стадия пошива
            CUTTER, //стадия раскроя
            DESIGNER, //стадии художественного и технологического эскизов
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

            //Required - не может быть null
            [Required] [MaxLength(50)] public string Surname { get; set; } // фамилия
            [Required] [MaxLength(50)] public string Name { get; set; } // имя 
            [MaxLength(50)] public string Patronymic { get; set; } // отчество
            [Required] public DateTime DeviceDate { get; set; } // дата устройства
            [Required] public string Salary { get; set; } //оклад
            [Required] [MaxLength(15)]  public string Login { get; set; }
            [Required] [MaxLength(15)] public string Password { get; set; }
            [Required] public Role Role { get; set; }
        }

        public class Material // материал
        {
            public int ID { get; set; }
            [Required] public string Name { get; set; }

            public ModelColor Сolor { get; set; }

            public ICollection<Blueprint> RelatedBlueprints { get; set; }
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

            public ICollection<Material> Materials { get; set; }

            [Required] public DateTime CreationDate { get; set; }
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
            /// Получение этапа
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

            // Асинхронность позволяет вынести отдельные задачи из основного потока в специальные асинхронные методы или блоки кода
            public static async Task RemoveFromDb(this Product initialProduct, AppDbContext db)
            {
                //await ставит на паузу текущий метод, ожидая выполнения задачи
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
