using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class BaseModel
    {
        public GUID Id { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public GUID CreatedBy { get; set; }
        public GUID UpdatedBy { get; set; }
    }
}
