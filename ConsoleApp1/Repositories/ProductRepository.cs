using System;
using System.Collections.Generic;
using ConsoleApp1.Entities;

namespace ConsoleApp1.Repositories
{
    public class ProductRepository : Neo4jRepository
    {
        public ProductRepository() : base("Product") { }

        public Product CreateProduct(Brand brand, object native, App app, IEnumerable<App> thirdParyApps, string name)
        {
            throw new NotImplementedException();
        }
    }
}