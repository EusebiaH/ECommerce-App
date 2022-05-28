using Internship.Data.Vats;
using MediatR;

namespace Internship.Business.Vats.Queries.GetById
{
    public class GetVatByIdQuery:IRequest<GetVatByIdResult>
    {
        public int Id { get; set; }

        public GetVatByIdQuery(int id)
        {
            Id= id;
        }
    }
}
