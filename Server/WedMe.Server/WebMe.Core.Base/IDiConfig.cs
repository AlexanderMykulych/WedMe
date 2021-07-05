using System;
using Autofac;

namespace WedMe.Core.Base
{
    public interface IDiConfig
    {
        public ContainerBuilder Configurate(ContainerBuilder builder);
    }
}