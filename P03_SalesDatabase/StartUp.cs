using P03_SalesDatabase.Data;
using P03_SalesDatabase.Data.IOManagement;
using P03_SalesDatabase.Data.IOManagement.Contracts;
using P03_SalesDatabase.Data.Models;
using P03_SalesDatabase.Data.Seeding;
using P03_SalesDatabase.Data.Seeding.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_SalesDatabase
{
    class StartUp
    {
        static void Main(string[] args)
        {
            SalesContext dbContext = new SalesContext();
            //Random random = new Random();
            //IWriter consoleWriter = new ConsoleWriter();

            //ICollection<ISeeder> seeders = new List<ISeeder>();
            //seeders.Add(new ProductSeeder(dbContext, random, consoleWriter));
            //seeders.Add(new StoreSeeder(dbContext, consoleWriter));

            //foreach (ISeeder seeder in seeders)
            //{
            //    seeder.Seed();
            //}

            Sale sale = new Sale()
            {
                CustomerId = 1,
                ProductId = 1,
                StoreId = 1
            };

            dbContext.Sales.Add(sale);
            dbContext.SaveChanges();

            Sale[] sales = dbContext.Sales.ToArray();

            foreach (Sale saleI in sales)
            {
                Console.WriteLine($"Sale ({saleI.SaleId} {saleI.Date})");
            }
        }
    }
}
