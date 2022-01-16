using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectOop
{
    namespace Entities // сущности
    {
        public enum Role
        {
            DIRECTOR, // директор, может всё
            SEAMSTRESS, // швея, стадия пошива
            CUTTER, // раскройщик, стадия раскроя
            DESIGNER, // модельек, стадии художественного и технологического эскизов
            TECHNOLOGIST // технолог, контроль качества
        }

        public class Employee // сотрудник
        {
            public int ID { get; set; }
            public string Login { get; set; }
            public string Password { get; set; }
            [Required] [MaxLength(50)] public string Surname { get; set; } // фамилия 
            [Required] [MaxLength(50)] public string Name { get; set; } // имя
            [MaxLength(50)] public string Patronymic { get; set; } // отчество
            [Required] public DateTime DeviceDate { get; set; } // дата устройства
            [Required] public string Salary { get; set; } //оклад

            public Role Role { get; set; }
        }

        public class Material // материал
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public double Amount { get; set }

        }

        public class ModelColor
        {
            public int ID { get; set; }
            public string RgbValue { get; set; }
            public string TextName { get; set; }
        }

        public class Sketch
        {
            public int ID { get; set; }

            public string Name { get; set; }

            public string FileLocation { get; set; }

            public Employee Author { get; set; }

            public DateTime CreationDate { get; set; }
        }

        public class Blueprint
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public Employee Author { get; set; }

            public List<Material> Materials { get; set; }

            public DateTime CreationDate { get; set; }

        }

        public class Cut
        {
            public int ID { get; set; }

            public Employee Author { get; set; }

            public DateTime CreationDate { get; set; }
        }

        public class Sewing
        {
            public int ID { get; set; }

            public Employee Author { get; set; }

            public DateTime CreationDate { get; set; }
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
        }
    }
}
