using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Repositories
{
    public class CategoryRepository : Neo4jRepository
    {
        public Category CreateCategory(string cateogryName)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("id", Guid.NewGuid().ToString());
            parameters.Add("name", cateogryName);
            var result = Execute("CREATE (c:Category {id: {id}, name: {name}}) RETURN c.id as id", parameters);
            return new Category(Guid.Parse(result.First()["id"].ToString()), cateogryName);
        }

        public void DeleteAll()
        {
            Execute("MATCH (c:Category) DETACH DELETE c");
        }
    }
}