using OnionArchitectureApp.Application.Interfaces.Repositories;
using OnionArchitectureApp.Domain.Entities;
using OnionArchitectureApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Persistence.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext): base(dbContext)
        {

        }
    }
}
