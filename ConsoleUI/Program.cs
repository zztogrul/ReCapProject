using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAllByBrandId(3))
            {
                Console.WriteLine(brand.BrandName);
            }
            // brandManager.Delete(new Brand { BrandId = 2, BrandName = "A" });
        }

    }
}