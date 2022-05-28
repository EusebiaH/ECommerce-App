using AutoMapper;
using Internship.Business.ProductCategoryXAttributes.Commands.Create;
using Internship.Business.ProductCategoryXAttributes.Queries.Filter;
using Internship.Controllers.ProductCategoryXAttributes.Models;
using Internship.Data;

namespace Internship.Controllers.ProductCategoryXAttributes.Mappings
{
    public class ProductCategoryXAttributeMapper : Profile 
    {
        public ProductCategoryXAttributeMapper()
        {
            CreateMap<PostProductCategoryXAttributeCommand, ProductCategoryXAttribute>();
            CreateMap<ProductCategoryXAttribute, PostProductCategoryXAttributeResult>();



            CreateMap<ProductCategoryXAttribute, GetAllProductCategoryXAttributeResult>().ForMember(x => x.ProductCategoryName, map => map.MapFrom(p => p.ProductCategory.Name))
                                                                                          .ForMember(x => x.AttributeName, map => map.MapFrom(a => a.Attribute.Name));

            CreateMap<ProductCategoryXAttribute, GetProductCategoryXAttributeById>();

        }
    }
}
