namespace services;

    using entities;
    using System.Collections.Generic;
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
    }