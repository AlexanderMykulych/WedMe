using System;

namespace WedMe.Core.Models
{
    public record BaseEntity (Guid Id)
    {
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedOn { get; set; } = DateTime.UtcNow;
        public Contact? CreatedBy { get; set; }
        public Guid? CreatedById { get; set; }
        public Contact? ModifiedBy { get; set; }
        public Guid? ModifiedById { get; set; }
    }
}