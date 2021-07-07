using Autofac;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WedMe.Core.Base;
using Autofac.Extensions.DependencyInjection;

namespace WedMe.Core.EfCore.DbContext
{
    public class DiConfig: IDiConfig
    {
        public ContainerBuilder Configurate(ContainerBuilder builder)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection
                .AddPooledDbContextFactory<ApplicationDbContext>(contextOptionsBuilder =>
                {
                    contextOptionsBuilder.UseInMemoryDatabase("Test");
                });
            builder.Populate(serviceCollection);
            
            return builder;
        }
    }
}