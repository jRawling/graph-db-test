using Neo4j.Driver.V1;
using System.Collections.Generic;

namespace ConsoleApp1.Repositories
{
    public abstract class Neo4jRepository
    {
        private readonly string Server = "bolt://localhost:3203";
        private readonly IAuthToken AuthToken = AuthTokens.Basic("neo4j", "password");

        protected IStatementResult Execute(string statement)
        {
            using (var driver = GraphDatabase.Driver(Server, AuthToken))
            using (var session = driver.Session())
            {
                return session.Run(statement);
            }
        }

        protected IStatementResult Execute(string statement, Dictionary<string, object> parameters)
        {
            using (var driver = GraphDatabase.Driver(Server, AuthToken))
            using (var session = driver.Session())
            {
                return session.Run(statement, parameters);
            }
        }
    }
}