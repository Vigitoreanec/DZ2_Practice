
using System.Linq;

namespace DZ2_Practice.Model;

public class RepositoryProduct : IRepositoryProduct
{
    private readonly List<Product> products = new List<Product>();
    public void Create(Product product)
    {
        Console.WriteLine($" Продукт NEW:\n");
        products.Add(product);
        ToWrite(product);
    }
    public void ToWrite(Product product)
    {
        Console.WriteLine($"ID - {product.Id}, Name - {product.Name}, Price - {product.Price}, Date - \"{product.Input}\", Quantity - {product.Quantity}");
    }
    public Product Read(int id) // не понял как реализовать если такого продукта нет((((
    {
        //try
        //{
        //    return products.First(p => p.Id == id);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        return products.First(p => p.Id == id);
    }
    public void Update(Product product)
    {
        var newproduct = products.Where(p => p.Id == product.Id).FirstOrDefault();
        if (newproduct != null)
        {
            products.Remove(newproduct);
        }
        else
        {
            products.Add(product);// так для примера
        }
    }
    public void Delete(Product product)
    {
        products.RemoveAll(p => p.Id == product.Id);
    }

    public IEnumerable<Product> ReadAll()
    {
        return products;
    }
}
