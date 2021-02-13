using OnionArchitectureApp.Application.Dtos;
using OnionArchitectureApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Application.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T: BaseEntity
    {
        Task<List<T>> GetAll();

        Task<T> GetById(Guid id);

        Task<T> AddAsync(T entity);
    }
}
