namespace services;
using entities;
using repository;

public class ProductService : IProductService
{
    private readonly IRepository _repository;

    public ProductService(IRepository productRepository)
    {
        _repository = productRepository;
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return _repository.GetAllProducts();
    }
}
