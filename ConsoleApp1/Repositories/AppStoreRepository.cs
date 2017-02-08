using ConsoleApp1.Entities;
using Neo4j.Driver.V1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Repositories
{
    public class AppStoreRepository : Neo4jRepository
    {
        public AppStore CreateAppStore(string appStoreName)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("id", Guid.NewGuid().ToString());
            parameters.Add("name", appStoreName);
            var result = Execute("CREATE (as:AppStore {id: {id}, name: {name}}) RETURN as.id as id", parameters);
            return new AppStore(Guid.Parse(result.First()["id"].ToString()), appStoreName);
        }

        public void DeleteAll()
        {
            Execute("MATCH (as:AppStore) DETACH DELETE as");
        }

    }
}