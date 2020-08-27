using Abp.Dependency;
using GraphQL;
using GraphQL.Types;
using AspZeroDemo.AbpZeroDemo.Queries.Container;

namespace AspZeroDemo.AbpZeroDemo.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IDependencyResolver resolver) :
            base(resolver)
        {
            Query = resolver.Resolve<QueryContainer>();
        }
    }
}