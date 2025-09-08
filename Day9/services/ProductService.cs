namespace services;
using entities;
using repository;

public class ProductService : IProductService
{
    private readonly List<Product> _products;

    public ProductService(IRepository productRepository)
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
        return _products;
    }
}
