using System;
using Core.Entities;

namespace Core.Interfaces;

public interface IProductRespository
{
    Task<IReadOnlyList<Product>> GetProductsAsync();

    Task<Product?> GetProductByIdAsync(int id);

    Task<IReadOnlyList<string>> GetBrandAsync();

    Task<IReadOnlyList<string>> GetTypesAsync();

    void AddProduct(Product product);

    void UpdateProduct(Product product);

    void DeleteProduct(Product product);

    bool ProductExists(int id);

    Task<bool> SaveChangesAsync();

}
