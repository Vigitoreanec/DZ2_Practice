
using DZ2_Practice.Data;
using DZ2_Practice.Model;

namespace DZ2_Practice;

public class ClassMenu()
{
    public void Run(ProductController _productController)
    {
        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Вывести все продукты");
            Console.WriteLine("2. Вывести продукт по номеру");
            Console.WriteLine("3. Создать продукт");
            Console.WriteLine("4. Обновить продукт");
            Console.WriteLine("5. Удалить продукт");
            Console.WriteLine("6. Выход");

            var choice = Console.ReadLine();
            Console.Clear();
            switch (choice)
            {
                case "1":
                    GetAllProducts(_productController);
                    break;
                case "2":
                    GetProductById(_productController);
                    break;
                case "3":
                    CreateProduct(_productController);
                    break;
                case "4":
                    UpdateProduct(_productController);
                    break;
                case "5":
                    DeleteProduct(_productController);
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }

        }
    }

    private void DeleteProduct(ProductController productController)
    {
        Console.Write("Введите ID продукта: ");
        int id = int.Parse(Console.ReadLine());
        var product = productController.GetProductById(id);
        productController.DeleteProduct(product);
        Console.WriteLine("Продукт успешно удален.");
    }

    private void UpdateProduct(ProductController productController)
    {
        Console.Write("Введите ID продукта: ");
        int id = int.Parse(Console.ReadLine());

        var product = productController.GetProductById(id);
        if (product != null)
        {
            Console.Write("Введите новое название продукта: ");
            string _name = Console.ReadLine();
            Console.Write("Введите новую цену: ");
            double _price = double.Parse(Console.ReadLine());
            
            Console.Write("Введите новое количество: ");
            int _quantity = int.Parse(Console.ReadLine());
            product.Name = _name;
            product.Price = _price;
            product.Quantity = _quantity;
            productController.UpdateProduct(product);
            Console.WriteLine("Продукт успешно обновлен.");
        }
        else
        {
            Console.WriteLine("Продукт с таким ID не найден.");
        }
    }

    private void CreateProduct(ProductController productController)
    {
        Console.Write("Введите название продукта: ");
        string _name = Console.ReadLine();
        Console.Write("Введите цену: ");
        double _price = double.Parse(Console.ReadLine());
        Console.Write("Введите Число: ");
        DateTime _date = DateTime.Now;
        Console.Write("Введите количество: ");
        int _quantity = int.Parse(Console.ReadLine());

        int number = productController.GetAllProducts().Count();
        if (number > 0)
        {
            number += 1;
        }
        else number = 1;

        Product newProduct = new Product/*(number,_name,_price,_date,_quantity)*/
        {
            Id = number,
            Name = _name,
            Price = _price,
            Input = _date,
            Quantity = _quantity
        };
        
        productController.CreateProduct(newProduct);
        Console.WriteLine("Создание прошло успешно!");
    }

    private void GetProductById(ProductController productController)
    {
        Console.Write("Введите ID продукта: ");
        int id = int.Parse(Console.ReadLine());
        if (id != null)
        {
            Product p = productController.GetProductById(id);
            Console.WriteLine($"ID - {p.Id}, Name - {p.Name}, Price - {p.Price}, Date - \"{p.Input}\", Quantity - {p.Quantity}");
        }
        else
        {
            Console.WriteLine("Продукт с таким ID нет.");
        }
    }

    private void GetAllProducts(ProductController productController)
    {
        Console.WriteLine("Список продуктов:");
        var products = productController.GetAllProducts();
        foreach (var p in products)
        {
            Console.WriteLine($"ID - {p.Id}, Name - {p.Name}, Price - {p.Price}, Date - \"{p.Input}\", Quantity - {p.Quantity}");
        }
    }
}
