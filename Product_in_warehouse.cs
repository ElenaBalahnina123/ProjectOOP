using System;

public class Product_in_warehouse
{
	public int ID { get; set; }
	// ид товара, склада
	[Required] public int Quantity { get; set; }
	[Required] [MaxLength(15)] public string Size { get; set; }
	[Required] public string Color { get; set; }
}
