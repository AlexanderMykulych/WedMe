using System;

namespace WedMe.Core.Models
{
    public record Contact: BaseEntity 
    {
        public Contact(Guid id) : base(id)
        {
        }
    }
}