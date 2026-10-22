namespace Adv_Assignment_02.DataModels_ProductCatalog;

public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Category { get; set; } // "Electronics", "Clothing", "Food", "Books"
    public double Price { get; set; }
    public int Stock { get; set; }
}



