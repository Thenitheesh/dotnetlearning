namespace repository;
using System.Collections.Generic;
using entities;

public interface IRepository
{
    IEnumerable<Product> GetAllProducts();
    // void DeleteProduct(Product product);

    // Product GetProductById(int id);

    // void AddProduct(Product product);

    // void UpdateProduct(Product product);
}