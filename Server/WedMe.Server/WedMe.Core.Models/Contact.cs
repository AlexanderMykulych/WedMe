using System;

namespace WedMe.Core.Models
{
    public record Contact (Guid Id): BaseEntity (Id) 
    {
        public string? Name { get; set; }
    }
}