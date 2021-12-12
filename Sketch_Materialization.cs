using System;

public class Sketch_Materialization
{
    public int ID { get; set; }
    [Required] [MaxLength(15)] public string Size { get; set; }
    // ид артикула, сотрудника
    [Required] public DateTime Creation_Date { get; set; }
    [Required] public string Degree_Development { get; set; }
}
