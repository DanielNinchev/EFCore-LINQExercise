using P03_SalesDatabase.Data.IOManagement.Contracts;
using P03_SalesDatabase.Data.Models;
using P03_SalesDatabase.Data.Seeding.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03_SalesDatabase.Data.Seeding
{
    public class StoreSeeder : ISeeder
    {
        private readonly SalesContext dbContext;
        private readonly IWriter writer;

        public StoreSeeder(SalesContext context, IWriter writer)
        {
            this.dbContext = context;
            this.writer = writer;
        }

        public void Seed()
        {
            Store[] stores = new Store[]
            {
                new Store() {Name = "PcTech Sofia"},
                new Store() {Name = "PcTech Plovdiv"},
                new Store() {Name = "PcTech Varna"},
                new Store() {Name = "PcTech Burgas"},
                new Store() {Name = "PcTech Ruse"}
            };

            this.dbContext.Stores.AddRange(stores);
            this.dbContext.SaveChanges();

            this.writer.WriteLine($"{stores.Length} stores were added to the database!");
        }
    }
}
