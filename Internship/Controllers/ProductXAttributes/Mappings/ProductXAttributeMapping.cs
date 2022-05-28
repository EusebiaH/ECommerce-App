using AutoMapper;
using Internship.Business.ProductXAttributes.Commands.Create;
using Internship.Business.ProductXAttributes.Commands.Update;
using Internship.Business.ProductXAttributes.Queries.Filter;
using Internship.Controllers.ProductXAttributes.Models;
using Internship.Data;

namespace Internship.Controllers.ProductXAttributes.Mappings
{
    public class ProductXAttributeMapping:Profile
    {
        public ProductXAttributeMapping()
        {
            CreateMap<CreateProductXAttributeCommand, ProductXAttribute>();
            CreateMap<ProductXAttribute, CreateProductXAttributeResult>();
            CreateMap<CreateProductXAttributeRequest, CreateProductXAttributeCommand>();
            CreateMap<UpdateProductXAttributeCommand, ProductXAttribute>();
            CreateMap<ProductXAttribute, UpdateProductXAttributeResult>();

            CreateMap<ProductXAttribute, GetAllProductXAttributeQuery>();
            CreateMap<ProductXAttribute, GetAllProductXAttributeResult>()
                        .ForMember(p => p.AttributeId, map => map.MapFrom(prop => prop.Attribute.Id))
                        .ForMember(p => p.ProductId, map => map.MapFrom(prop => prop.Product.Id))
                        .ForMember(p => p.ProductTypeId, map => map.MapFrom(prop => prop.Product.ProductType.Id))
                        .ForMember(p => p.ProductCategoryId, map => map.MapFrom(prop => prop.Product.ProductCategory.Id))
                        .ForMember(p => p.ProductCategoryName, map => map.MapFrom(prop => prop.Product.ProductCategory.Name))
                        .ForMember(p => p.ProductTypeName, map => map.MapFrom(prop => prop.Product.ProductType.Name))
                        .ForMember(p => p.ManufracturerName, map => map.MapFrom(prop => prop.Product.Manufacturer.Name))
                        .ForMember(p => p.VatName, map => map.MapFrom(prop => prop.Product.VAT.Name))
                        .ForMember(p => p.AttributeId, map => map.MapFrom(prop => prop.Attribute.Id));


            CreateMap<UpdateProductXAttributeRequest, UpdateProductXAttributeCommand>();
            CreateMap<ProductXAttribute, UpdateProductXAttributeCommand>()
                        .ForMember(p => p.AttributeId, map => map.MapFrom(prop => prop.Attribute.Id))
                        .ForMember(p => p.ProductId, map => map.MapFrom(prop => prop.Product.Id));

        }
    }
}
