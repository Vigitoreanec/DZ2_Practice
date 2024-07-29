using DZ2_Practice.Model;
using System.Numerics;

namespace DZ2_Practice.Data;

public class ProductController
{
    private readonly IRepositoryProduct _repositoryProduct;

    public ProductController(IRepositoryProduct repositoryProduct)
    {
        _repositoryProduct = repositoryProduct;
    }

    public void CreateProduct(Product product)
    {
        _repositoryProduct.Create(product);
    }
    public void UpdateProduct(Product product)
    {
        _repositoryProduct.Update(product);
    }
    public void DeleteProduct(Product product)
    {
        _repositoryProduct.Delete(product);
    }
    public Product GetProductById(int id)
    {
        return _repositoryProduct.Read(id);
    }
    public IEnumerable<Product> GetAllProducts()
    {
        return _repositoryProduct.ReadAll();
    }
}
