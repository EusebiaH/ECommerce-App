using AutoMapper;
using Internship.Business.ProductCategories.Commands.Create;
using Internship.Controllers.ProductCategories.Models;

namespace Internship.Data.ProductCategorys
{
    public class ProductCategoryProfile : Profile
    {
        public ProductCategoryProfile()
        {
            CreateMap<PostProductCategoryCommand,ProductCategory>();
            CreateMap<ProductCategory, PostProductCategoryResult>();

            CreateMap<ProductCategory, GetProductCategoryIdResult>();

            CreateMap<ProductCategory, UpdateProductCategoryRequest>();
            CreateMap<UpdateProductCategoryRequest, UpdateProductCategoryResult>();
          
        }
    }
}
