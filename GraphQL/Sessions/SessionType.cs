using ConferencePlanner.GraphQL.Data;
using ConferencePlanner.GraphQL.Tracks;
using HotChocolate.Types;

namespace ConferencePlanner.GraphQL.Sessions
{
    public class SessionType : ObjectType<Session>
    {
        protected override void Configure(IObjectTypeDescriptor<Session> descriptor)
        {
            descriptor
                .Field(x => x.Track)
                // if the resolver is not used type is non-nullable
                .ResolveWith<SessionResolvers>(x => x.GetTrackSession(default!, default!))

                // Track will be nullable until the line below is enabled
                .Type<NonNullType<TrackType>>()
                .UseDbContext();
        }
    }
}
