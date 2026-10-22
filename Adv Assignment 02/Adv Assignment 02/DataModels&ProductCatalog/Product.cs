using static System.Net.WebRequestMethods;

namespace Adv_Assignment_02.DataModels_ProductCatalog;

public class Product
{
    #region prorperties
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Category { get; set; } // "Electronics", "Clothing", "Food", "Books"
    public double Price { get; set; }
    public int Stock { get; set; }
    #endregion

    #region Methods
    // searchproducts Method 
    public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter)// Func delegate: accepts a Product and returns bool to determine if it matches the filter
    {
        List<Product> result = new List<Product>();

        foreach (Product product in products)
        {
            if (filter(product))
            {
                result.Add(product);
            }
        }

        return result;
    }



    public static void PrintReport(List<Product>products, Action<Product> printProduct) // Action accepts a Product and performs an operation without returning a value
    {
        foreach (var item in products)
        {
            printProduct(item);
        }
    }


    

    #endregion
}



