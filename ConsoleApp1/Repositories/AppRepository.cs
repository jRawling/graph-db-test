using ConsoleApp1.Entities;
using Neo4j.Driver.V1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Repositories
{
    public class AppRepository : Neo4jRepository
    {
        public AppRepository() : base("App") { }

        public App CreateApp(AppStore appStore, Brand brand, string name)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("id", Guid.NewGuid().ToString());
            parameters.Add("name", name);
            parameters.Add("appStoreId", appStore.Id.ToString());
            parameters.Add("brandId", brand.Id.ToString());
            var result = Execute("MATCH  (as:" + Label + "), (b:Brand) WHERE as.id = {appStoreId} AND b.id = {brandId} " +
                "CREATE (app:App {id: {id}, name: {name}})-[:made_by]->(b), (app)-[:available_on]->(as) RETURN app.id as id", parameters);
            return new App(Guid.Parse(result.First()["id"].ToString()), name);
        }
    }
}