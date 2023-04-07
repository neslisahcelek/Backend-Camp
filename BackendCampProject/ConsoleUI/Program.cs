// See https://aka.ms/new-console-template for more information
using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Business.Abstract;
using DataAccess.Abstract;

using System.Linq;
using System.Text;
using DataAccess.Concrete.EntityFramework;

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