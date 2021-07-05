using Autofac;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebMe.Core.Base;
using Autofac.Extensions.DependencyInjection;

namespace WedMe.Core.EfCore.DbContext
{
    public class DiConfig: IDiConfig
    {
        public ContainerBuilder Configurate(ContainerBuilder builder)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContextPool<ApplicationDbContext>(contextOptionsBuilder =>
            {
                contextOptionsBuilder.UseInMemoryDatabase("Test");
            });
            builder.Populate(serviceCollection);
            
            return builder;
        }
    }
}