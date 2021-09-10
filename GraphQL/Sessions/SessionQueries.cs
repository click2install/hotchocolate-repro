using System.Linq;
using ConferencePlanner.GraphQL.Data;
using HotChocolate;
using HotChocolate.Types;

namespace ConferencePlanner.GraphQL.Sessions
{
    [ExtendObjectType(OperationTypeNames.Query)]
    public class SessionQueries
    {
        public IQueryable<Session> GetSessions([ScopedService] ApplicationDbContext context)
        {
            return context.Sessions;
        }
    }
}
