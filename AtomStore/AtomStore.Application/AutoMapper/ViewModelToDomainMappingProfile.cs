using AtomStore.Application.ViewModels.Product;
using AtomStore.Data.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtomStore.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile:Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProductCategoryViewModel, ProductCategory>()
                .ConstructUsing(c => new ProductCategory(c.Name, c.ParentId, c.HomeOrder, c.HomeFlag,
                c.SortOrder, c.Status, c.SeoPageTitle, c.SeoAlias, c.SeoKeywords, c.SeoDescription));
        }
    }
}
