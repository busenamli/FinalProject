using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            Console.WriteLine("\n****************************\n");
            //CategoryTest();

            //DTOs --> Data Transformation Object

            ProductManager productManager = new ProductManager(new EFProductDal());

            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + " --> " + product.CategoryName);
            }


            Console.ReadKey();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }

            Console.WriteLine("\n****************************\n");

            Console.WriteLine(categoryManager.GetById(3).CategoryName);
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EFProductDal());

            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName + " --> " + product.CategoryId);
            }

            Console.WriteLine("\n****************************\n");

            foreach (var product in productManager.GetByUnitPrice(40, 100))
            {
                Console.WriteLine(product.ProductName + " --> " + product.UnitPrice);
            }
        }
    }
}
