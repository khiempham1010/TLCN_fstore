
using AtomStore.Application.ViewModels.Product;
using AtomStore.Application.ViewModels.System;
using AtomStore.Data.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtomStore.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile:Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<Product, ProductViewModel>(); 
            CreateMap<Function, FunctionViewModel>();
        }
    }
}
