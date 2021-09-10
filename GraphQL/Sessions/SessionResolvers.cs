using System.Linq;
using ConferencePlanner.GraphQL.Data;
using HotChocolate;

namespace ConferencePlanner.GraphQL.Sessions
{
    public class SessionResolvers
    {
        public Track GetTrackSession(Session session, [ScopedService] ApplicationDbContext context)
        {
            return context.Tracks.Single(x => x.Id == session.TrackId);
        }
    }
}
