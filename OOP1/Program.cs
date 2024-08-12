using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.ID = 1;
            product.ProductName = "Masa";
            product.CategoryId = 2;
            
            Product product2 = new Product { ID=2,CategoryId=5,UnitsInStock=10,ProductName="Kalem",UnitPrice=35};

            ProductManager productManager = new ProductManager();

            productManager.Add(product);

            int sayi = 100;
            productManager.a(sayi);
            Console.WriteLine(sayi);
        }

    }
    
}

