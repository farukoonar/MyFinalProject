using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID - Open Closed Principle - Yeni özellik eklendiğinde mevcut kodlara dokunamazsın
    //EF ekledik ve mevcut kodlarımıza dokunmadık
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            //foreach (var product in productManager.GetAllByCategory(2))
            //{
            //    Console.WriteLine(product.ProductName+" "+product.CategoryId);
            //}

            foreach (var product in productManager.GetAllByUnitPrice(50,100))
            {
                Console.WriteLine(product.ProductName + " " + product.UnitPrice);
            }

        }
    }
}
