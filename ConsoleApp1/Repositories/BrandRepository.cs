using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Repositories
{
    public class BrandRepository : Neo4jRepository
    {
        public Brand CreateBrand(string brandName)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("id", Guid.NewGuid().ToString());
            parameters.Add("name", brandName);
            var result = Execute("CREATE (b:Brand {id: {id}, name: {name}}) RETURN b.id as id", parameters);
            return new Brand(Guid.Parse(result.First()["id"].ToString()), brandName);
        }

        public void DeleteAll()
        {
            Execute("MATCH (b:Brand) DETACH DELETE b");
        }
    }
}