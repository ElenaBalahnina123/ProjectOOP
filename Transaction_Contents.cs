using System;

public class Transaction_Contents
{
    public int ID { get; set; }
    // id транзакции
    // ид артикула
    [Required] public int Quantity { get; set; }
    [Required] [Column(TypeName = "money")] public decimal Price { get; set; }
    [Required] public long INN { get; set; }
}
