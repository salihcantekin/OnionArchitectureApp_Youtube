using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitectureApp.Domain.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
