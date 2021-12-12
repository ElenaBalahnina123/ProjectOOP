using System;

public class Product_delivery
{
    public int ID { get; set; }
    // ид товара, поствки товара, склада готовой продукции
    [Required] public int Quantity { get; set; }
    [Required] [MaxLength(15)] public string Size { get; set; }
    [Required]  public string Color { get; set; }
}
