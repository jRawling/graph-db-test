using System;
using System.Collections.Generic;

namespace ConsoleApp1.Repositories
{
    public class BrandRepository : Neo4jRepository, IBrandRepository
    {
        public void CreateBrand(string brandName)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("id", Guid.NewGuid().ToString());
            parameters.Add("name", brandName);
            var result = Execute("CREATE (b:Brand {id: {id}, name: {name}})", parameters);
        }

        public void DeleteAll()
        {
            Execute("MATCH (b:Brand) DETACH DELETE b");
        }
    }
}