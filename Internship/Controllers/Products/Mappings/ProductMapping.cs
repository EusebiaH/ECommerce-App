using AutoMapper;
using Internship.Business.Products.Commands;
using Internship.Business.Products.Commands.Update;
using Internship.Business.Products.Queries;
using Internship.Controllers.Products.Models;
using Internship.Data;

namespace Internship.Controllers.Products.Mappings
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<PostProductRequest, PostProductCommand>();
            CreateMap<PostProductCommand, Product>();
            CreateMap<Product, PostProductResult>();
            CreateMap<UpdateProductRequest, UpdateProductCommand>();
            CreateMap<UpdateProductCommand, Product>();
            CreateMap<Product, UpdateProductResult>();
            CreateMap<Product, GetProductsResult>();

        }
    }
}
