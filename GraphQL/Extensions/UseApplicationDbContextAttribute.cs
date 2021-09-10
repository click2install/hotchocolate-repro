using System.Reflection;
using HotChocolate.Types;
using HotChocolate.Types.Descriptors;

namespace ConferencePlanner.GraphQL
{
    public class UseDbContextAttribute : ObjectFieldDescriptorAttribute
    {
        public override void OnConfigure(IDescriptorContext context, IObjectFieldDescriptor descriptor, MemberInfo member)
        {
            descriptor.UseDbContext();
        }
    }
}