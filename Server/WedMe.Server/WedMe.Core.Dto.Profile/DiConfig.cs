using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using WedMe.Core.Base;

namespace WedMe.Core.Dto.Profile
{
    public class DiConfig: IDiConfig
    {
        public ContainerBuilder Configurate(ContainerBuilder builder)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddAutoMapper(GetType().Assembly);
            builder.Populate(serviceCollection);
            return builder;
        }
    }
}