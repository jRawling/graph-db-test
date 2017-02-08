using System;
using System.Collections.Generic;

namespace ConsoleApp1.Repositories
{
    public class ProductRepository : Neo4jRepository
    {
        public void DeleteAll()
        {
            Execute("MATCH (p:Product) DETACH DELETE p");
        }
    }
}