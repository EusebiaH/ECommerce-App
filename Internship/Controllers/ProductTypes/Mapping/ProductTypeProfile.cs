using AutoMapper;
using Internship.Business.ProductTypes.Commands.Create;
using Internship.Business.ProductTypes.Commands.Delete;
using Internship.Business.ProductTypes.Commands.Update;
using Internship.Business.ProductTypes.Queries.Filter;
using Internship.Business.ProductTypes.Queries.GetByld;
using Internship.Controllers.ProductTypes.Models;
using Internship.Data;
using Internship.Data.ProductsType;

namespace Internship.Controllers.ProductTypes.Mapping
{
    public class ProductTypeProfile : Profile
    {
        public ProductTypeProfile()
        {
            CreateMap<ProductType, GetProductTypeByIdResult>();
            CreateMap<ProductTypeRequest, DeleteProductTypeCommand>();
            CreateMap<ProductType, DeleteProductTypeCommand>();
            CreateMap<ProductType, FIlterProductTypeQuery>();
            CreateMap<ProductType, UpdateProductTypeCommand>();
            CreateMap<ProductTypeRequest, UpdateProductTypeCommand>();
            CreateMap<GetProductTypeByIdQuery, ProductType>();
            CreateMap<CreateProductTypeCommand, ProductType>();
            CreateMap<ProductType, GetAllProductTypeResult>();


        }
    }
}