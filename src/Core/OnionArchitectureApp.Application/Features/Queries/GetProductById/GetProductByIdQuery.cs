using MediatR;
using OnionArchitectureApp.Application.Dtos;
using OnionArchitectureApp.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitectureApp.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQuery: IRequest<ServiceResponse<GetProductByIdViewModel>>
    {
        public Guid Id { get; set; }




    }
}
