namespace DZ2_Practice.Model;
public interface IRepositoryProduct
{
    void Create(Product product);
    void Delete(Product product);
    void Update(Product product);
    Product Read(int id);
    IEnumerable<Product> ReadAll();
}