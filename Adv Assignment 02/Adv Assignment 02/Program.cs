using Adv_Assignment_02.DataModels_ProductCatalog;

namespace Adv_Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region searchMethod
            //Console.WriteLine("---Electronics---");
            //// Search by category
            //List<Product> category = Product.SearchProducts(ProductCatalog.catalog, p => p.Category == "Electronics"); // use Lambda Expression to filter products by category
            //foreach (var item in category)
            //{
            //    Console.WriteLine($"{item.Name} - ${item.Price} (stock: {item.Stock})");
            //}
            //Console.WriteLine();


            //Console.WriteLine("---Under $50---");
            //List<Product> price = Product.SearchProducts(ProductCatalog.catalog, p => p.Price < 50); // use Lambda Expression to filter products by price
            //foreach (var item in price)
            //{
            //    Console.WriteLine($"{item.Name} - ${item.Price} (stock: {item.Stock})");
            //}
            //Console.WriteLine();


            //Console.WriteLine("---instock---");
            //List<Product> instock = Product.SearchProducts(ProductCatalog.catalog, p => p.Stock > 0); // use Lambda Expression to filter products by the count of items in stock
            //foreach (var item in instock)
            //{
            //    Console.WriteLine($"{item.Name} - ${item.Price} (stock: {item.Stock})");
            //}
            //Console.WriteLine();


            //Console.WriteLine("---Clothing Under $100---");
            //List<Product> clothing = Product.SearchProducts(ProductCatalog.catalog, p => p.Category == "Clothing" && p.Price < 100); // use Lambda Expression to filter products by category and price
            //foreach (var item in clothing)
            //{
            //    Console.WriteLine($"{item.Name} - ${item.Price} (stock: {item.Stock})");
            //}
            //Console.WriteLine();

            #endregion

            #region PrintMethod

            //Console.WriteLine("---Short Report---");
            //Product.PrintReport(ProductCatalog.catalog, p => Console.WriteLine($"{p.Name} - ${p.Price}"));
            //Console.WriteLine();

            //Console.WriteLine("---Detailed Report---");
            //Product.PrintReport(ProductCatalog.catalog, p => Console.WriteLine($"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}"));
            //Console.WriteLine();


            #endregion

            #region TransformProductsMethode

            Console.WriteLine("---Summary List---");
            List<string> summaryList =  Product.TransformProducts(ProductCatalog.catalog, p => $"{p.Name} (${p.Price})");
            foreach (var item in summaryList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("---Price Labels---");
            List<string> priceLapel = Product.TransformProducts(ProductCatalog.catalog, p => $"{p.Name}: {(p.Price > 100 ? "Expensive!" : "Affordable")}");
            foreach (var item in priceLapel)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();




            #endregion
        }
    }
}
