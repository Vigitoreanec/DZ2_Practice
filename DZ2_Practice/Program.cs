// See https://aka.ms/new-console-template for more information
using DZ2_Practice;
using DZ2_Practice.Data;
using DZ2_Practice.Model;
using Microsoft.Extensions.DependencyInjection;
using System.Resources;



var serviceCollection = new ServiceCollection()
                .AddSingleton<IRepositoryProduct, RepositoryProduct>()
                .AddTransient<ProductController>()
                .BuildServiceProvider();
var productController = serviceCollection.GetService<ProductController>();// Получение через DI контейнер
Product product1 = new Product
{
    Id = 1,
    Name = Convert.ToString("Product 1"),
    Price = 123.33,
    Input = DateTime.Parse("2023,2,23"),
    Quantity = 123
};
productController.CreateProduct(product1);
product1 = new Product
{
    Id = 2,
    Name = Convert.ToString("Product 2"),
    Price = 333.11,
    Input = DateTime.Parse("2020,12,11"),
    Quantity = 321
};
productController.CreateProduct(product1);

ClassMenu menu = new ClassMenu();
menu.Run(productController);
