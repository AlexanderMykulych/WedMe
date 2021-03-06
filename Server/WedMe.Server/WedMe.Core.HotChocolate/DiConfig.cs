using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using WedMe.Core.Base;

namespace WedMe.Core.HotChocolate
{
    public class DiConfig: IDiConfig
    {
        public ContainerBuilder Configurate(ContainerBuilder builder)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection
                .AddGraphQLServer()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>();
            serviceCollection.AddScoped<Mutation>();            
            builder.Populate(serviceCollection);
            return builder;
        }
    }
}