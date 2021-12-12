using System;

public class Raw_material_puchase_transaction
{
    public int ID { get; set; }
    [Required] public DateTime Parchase_date { get; set; }
    
    //ид поставщика, склада, сотрудника
}
