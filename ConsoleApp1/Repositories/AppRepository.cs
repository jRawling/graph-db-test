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

        public App CreateApp(IEnumerable<AppStore> appStores, Brand brand, string name)
        {    
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("id", Guid.NewGuid().ToString());
            parameters.Add("brandId", brand.Id.ToString());
            parameters.Add("name", name);
            Dictionary<string, string> appStoreNodes = GetAppStoreNodes(appStores);
            AddAppStoreIdsToParameters(parameters, appStoreNodes);

            string matchClause = "MATCH ";

            foreach (string key in appStoreNodes.Keys)
            {
                matchClause += string.Format("({0}:AppStore {{id: {{{0}Id}}}}), ", key);
            }

            matchClause += "(b:Brand {id: {brandId}})";
            matchClause += string.Format(" \nCREATE (app:{0} {{id: {{id}}, name: {{name}}}}), (app)-[:made_by]->(b)", Label);

            foreach (string key in appStoreNodes.Keys)
            {
                matchClause += string.Format(", (app)-[:available_on]->({0})", key);
            }

            matchClause += " \nRETURN app.id as id;";
            var result = Execute(matchClause, parameters);
            return new App(Guid.Parse(result.First()["id"].ToString()), name);
        }

        private void AddAppStoreIdsToParameters(Dictionary<string, object> parameters, Dictionary<string, string> appStoreNodes)
        {
            foreach(KeyValuePair<string, string> node in appStoreNodes)
            {
                parameters.Add(string.Format("{0}Id", node.Key), node.Value);
            }
        }

        private Dictionary<string, string> GetAppStoreNodes(IEnumerable<AppStore> appStores)
        {
            Dictionary<string, string> nodes = new Dictionary<string, string>();
            int index = 0;
            foreach (AppStore appStore in appStores)
            {
                nodes.Add(string.Format("appStore{0}", index), appStore.Id.ToString());
                index++;
            }

            return nodes;
        }
    }
}