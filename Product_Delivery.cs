using System;

public class Product_Delivery
{
	public int ID { get; set; }
	// ид магазина
	[Required] public DateTime Delivery_Date { get; set; }
}
