using OnionArchitectureApp.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Application.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductViewDto>> GetAllProducts();
    }
}
