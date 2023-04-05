// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using System.Linq;
using System.Text;


namespace ConsoleUI
{
     class Program
    {
        static void Main(string[] args)
        {
            ProductManager pm = new ProductManager(new InMemoryProductDal());
            foreach (var product in pm.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }

}