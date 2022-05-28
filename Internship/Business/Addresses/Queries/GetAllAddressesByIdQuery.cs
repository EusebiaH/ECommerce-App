using Internship.Data;
using MediatR;

namespace Internship.Business.Addresses.Queries
{
    public class GetAllAddressesByIdQuery: IRequest<Address>
    {
        public int Id { get; set; } 

        public GetAllAddressesByIdQuery(int id)
        {
            Id = id;    
        }
    }
}
