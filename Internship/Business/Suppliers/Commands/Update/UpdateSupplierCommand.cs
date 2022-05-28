using MediatR;

namespace Internship.Business.Suppliers.Commands.Update
{
    public class UpdateSupplierCommand : IRequest<string>
    {
        public string Name { get; set; }
        public int AddressId{ get; set; }

        public UpdateSupplierCommand(string name, int addressId)
        {
            Name = name;
            AddressId = addressId;
        }
    }
}
