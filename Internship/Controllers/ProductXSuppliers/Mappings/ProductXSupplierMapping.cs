using AutoMapper;
using Internship.Business.ProductXSuppliers.Commands.Create;
using Internship.Business.ProductXSuppliers.Commands.Delete;
using Internship.Business.ProductXSuppliers.Commands.Update;
using Internship.Business.ProductXSuppliers.Queries.GetBySupplieId;
using Internship.Controllers.ProductXSuppliers.Models;
using Internship.Data;

namespace Internship.Controllers.ProductXSuppliers.Mappings
{
    public class ProductXSupplierMapping: Profile
    {
        public ProductXSupplierMapping()
        {
            CreateMap<PostPsRequest, PostPsCommand>();
            CreateMap<PostPsCommand, ProductXSupplier>();

            CreateMap<ProductXSupplier, PostPsResult>();

            CreateMap<ProductXSupplier, GetAllPsResult>().ForMember(x => x.ProductName, map => map.MapFrom(x => x.Product.Name))
                                                         .ForMember(x => x.SupplierName, map => map.MapFrom(x => x.Supplier.Id));

            CreateMap<DeletePsRequest, DeletePsCommand>();

            CreateMap<ProductXSupplier, DeletePsResult>();

            CreateMap<UpdatePsRequest, UpdatePsCommand>();

            CreateMap<ProductXSupplier, UpdatePsResult>();

            CreateMap<GetBySupplierIdRequest, GetBySupplierIdQuery>();

            CreateMap<ProductXSupplier, GetBySupplierIdResult>();

        }
    }
}
