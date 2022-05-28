using MediatR;

namespace Internship.Controllers.Suppliers.Models
{
    public class UpdateSupplierResult: IRequest<UpdateSupplierResult>
    {
        public string Name { get; set; }
        public int AddressId{ get; set; }
    }
}
