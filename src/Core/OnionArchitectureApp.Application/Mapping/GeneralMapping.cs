using AutoMapper;
using OnionArchitectureApp.Application.Features.Commands.CreateProduct;
using OnionArchitectureApp.Application.Features.Queries.GetProductById;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitectureApp.Application.Mapping
{
    public class GeneralMapping: Profile
    {

        public GeneralMapping()
        {
            CreateMap<Domain.Entities.Product, Dtos.ProductViewDto>()
                .ReverseMap();

            CreateMap<Domain.Entities.Product, CreateProductCommand>()
                .ReverseMap();

            CreateMap<Domain.Entities.Product, GetProductByIdViewModel>()
                .ReverseMap();
        }

    }
}
