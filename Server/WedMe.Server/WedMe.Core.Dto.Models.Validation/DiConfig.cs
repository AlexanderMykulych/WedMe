using Autofac;
using WedMe.Core.Base;

namespace WedMe.Core.Dto.Models.Validation {
    public class DiConfig: IDiConfig {
        public ContainerBuilder Configurate(ContainerBuilder builder) {
            
            builder.RegisterType<ContactDtoValidator>()
                .AsImplementedInterfaces();
            
            return builder;
        }
    }
}