
namespace DZ2_Practice.Model;

public class Product
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required double Price { get; set; }
    public required DateTime Input { get; set; }
    public required int Quantity { get; set; }
    //public Product(int id, string name, double price, DateTime dateInput, int quantity)
    //{
    //    Id = id;
    //    Name = name;
    //    Price = price;
    //    Input = dateInput;
    //    Quantity = quantity;
    //}
}
