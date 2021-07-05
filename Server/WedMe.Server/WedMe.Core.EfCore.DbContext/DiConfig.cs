using Autofac;
using WebMe.Core.Base;

namespace WedMe.Core.EfCore.DbContext
{
    public class DiConfig: IDiConfig
    {
        public ContainerBuilder Configurate(ContainerBuilder builder)
        {
            return builder;
        }
    }
}