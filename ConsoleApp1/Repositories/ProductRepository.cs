using System;
using System.Collections.Generic;

namespace ConsoleApp1.Repositories
{
    public class ProductRepository : Neo4jRepository
    {
        public ProductRepository() : base("Product") { }
    }
}