using Internship.Data;
using MediatR;

namespace Internship.Business.Addresses.Queries
{
    public class GetAllAddressesQuery: IRequest<List<Address>>
    {
    }
}
