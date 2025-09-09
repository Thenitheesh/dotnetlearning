namespace repository;

using entities;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

public class ProductRepository : IRepository
{
    private readonly List<Product> _products;

    public ProductRepository()
    {
        _products = new List<Product>
        {
            new Product { Id = 1, Title = "Product 1", Price = 9.99m, Description = "Description 1" },
            new Product { Id = 2, Title = "Product 2", Price = 19.99m, Description = "Description 2" },
            new Product { Id = 3, Title = "Product 3", Price = 29.99m, Description = "Description 3" }
        };
    }

    public IEnumerable<Product> GetAllProducts()
    {

        var baseDir = AppContext.BaseDirectory;
        var path = Path.Combine(baseDir, "Product.json");

        if (!File.Exists(path))
        {
            return _products;
        }

        try
        {
            string jsonData = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<Product>>(jsonData) ?? new List<Product>();
        }
        catch
        {
            return _products;
        }

    }

 
}
