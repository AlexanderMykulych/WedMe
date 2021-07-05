﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Autofac;
using Microsoft.Extensions.DependencyInjection;
using WedMe.Core.Base;

namespace WedMe.Configuration.AspNetCore.Base
{
    public static class WebMeConfiguration
    {
        public static ContainerBuilder AddWebMe(this ContainerBuilder builder)
        {
            var tempBuilder = new ContainerBuilder();
            tempBuilder.RegisterAssemblyModules(
                typeof(WedMe.Core.Base.IDiConfig).Assembly,
                typeof(WedMe.Core.EfCore.AspNetCore.DiConfig).Assembly,
                typeof(WedMe.Core.EfCore.DbContext.DiConfig).Assembly
            );
            var container = tempBuilder.Build();
            container.Resolve<IList<IDiConfig>>()
                ?.ToList()
                .ForEach(x => x.Configurate(builder));
            return builder;
        }
    }
}