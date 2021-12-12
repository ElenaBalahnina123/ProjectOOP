using System;

public class Sketch
{
    public int ID { get; set; }
    [Required] [MaxLength(50)] public string Name_Sketch { get; set; }
    //id сотрудника
    [Required] public DateTime Creation_Date { get; set; }
    [Required] [MaxLength(70)] public string Degree_Development { get; set; }
}
