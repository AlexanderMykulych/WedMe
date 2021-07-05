using System;
using Autofac;
using WedMe.Core.Base;

namespace WedMe.Core.EfCore.AspNetCore
{
    public class DiConfig: IDiConfig
    {
        public ContainerBuilder Configurate(ContainerBuilder builder)
        {
            return builder;
        }
    }
}