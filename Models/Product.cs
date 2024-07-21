namespace ProductApi.Models;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = null!;

    public decimal ProductPrice { get; set; }

    public bool ProductStatus { get; set; }
}