using System;
using Autofac;
using WebMe.Core.Base;

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