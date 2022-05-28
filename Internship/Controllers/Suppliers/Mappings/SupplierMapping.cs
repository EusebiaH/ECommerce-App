using AutoMapper;
using Internship.Business.Suppliers.Commands.Create;
using Internship.Business.Suppliers.Commands.Delete;
using Internship.Business.Suppliers.Commands.Update;
using Internship.Controllers.Suppliers.Models;
using Internship.Data;

namespace Internship.Controllers.Suppliers.Mappings
{
    public class SupplierMapping : Profile
    {
        public SupplierMapping()
        {
            CreateMap<PostSupplierRequest, PostSupplierCommand>();
            CreateMap<PostSupplierCommand, Supplier>();
            CreateMap<PostSupplierCommand, PostSupplierResult>();
            CreateMap<Supplier, PostSupplierResult>();
            CreateMap<Supplier, GetAllSuppliersResult>();
            CreateMap<DeleteSupplierRequest, DeleteSupplierCommand>();
            CreateMap<UpdateSupplierRequest, UpdateSupplierCommand>();
         
        }
        
    }
}
