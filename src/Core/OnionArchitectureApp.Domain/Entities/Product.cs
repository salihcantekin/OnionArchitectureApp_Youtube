using OnionArchitectureApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitectureApp.Domain.Entities
{
    public class Product: BaseEntity
    {
        public String Name { get; set; }

        public decimal Value { get; set; }

        public int Quantity { get; set; }
    }
}
