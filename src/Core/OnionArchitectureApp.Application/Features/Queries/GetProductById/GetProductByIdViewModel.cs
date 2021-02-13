using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitectureApp.Application.Features.Queries.GetProductById
{
    public class GetProductByIdViewModel
    {
        public Guid Id { get; set; }

        public DateTime CreateDate { get; set; }

        public String Name { get; set; }

        public decimal Value { get; set; }

        public int Quantity { get; set; }
    }
}
