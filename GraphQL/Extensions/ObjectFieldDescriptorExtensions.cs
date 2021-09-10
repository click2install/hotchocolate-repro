using ConferencePlanner.GraphQL.Data;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ConferencePlanner.GraphQL
{
    public static class ObjectFieldDescriptorExtensions
    {
        public static IObjectFieldDescriptor UseDbContext(this IObjectFieldDescriptor descriptor)
        {
            return descriptor.UseScopedService(
                create: s => s.GetRequiredService<IDbContextFactory<ApplicationDbContext>>().CreateDbContext(),
                disposeAsync: (s, c) => c.DisposeAsync());
        }
    }
}