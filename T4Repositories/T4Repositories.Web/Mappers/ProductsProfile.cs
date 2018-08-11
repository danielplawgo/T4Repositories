using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using T4Repositories.Models;
using T4Repositories.Web.ViewModel.Products;

namespace T4Repositories.Web.Mappers
{
    public class ProductsProfile : Profile
    {
        public ProductsProfile()
        {
            CreateMap<Product, ProductViewModel>()
                .ReverseMap();

            CreateMap<Product, IndexItemViewModel>();
        }
    }
}