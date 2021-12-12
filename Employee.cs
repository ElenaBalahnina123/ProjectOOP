using System;

public class Employee
{
    public int ID { get; set; }
    [Required] [MaxLength(50)] public string LastName { get; set; }
    [Required] [MaxLength(50)] public string FirstName { get; set; }
    [MaxLength(50)] public string MiddleName { get; set; }

    [Required] public DateTime Device_date { get; set; }
    [Required][Column(TypeName = "money")] public decimal Salary { get; set; }

    //ид должности


}
