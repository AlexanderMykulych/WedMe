using System;
using FluentValidation;

namespace WedMe.Core.Dto.Models.Validation {
    public class ContactDtoValidator : AbstractValidator<ContactDto> {
        public ContactDtoValidator() {
            RuleFor(x => x.Name)
                .NotNull();
        }
    }
}