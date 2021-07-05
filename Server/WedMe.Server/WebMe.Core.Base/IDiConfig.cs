using System;
using Autofac;

namespace WebMe.Core.Base
{
    public interface IDiConfig
    {
        public ContainerBuilder Configurate(ContainerBuilder builder);
    }
}