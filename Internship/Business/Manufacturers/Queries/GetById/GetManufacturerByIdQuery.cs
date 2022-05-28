using Internship.Controllers.Manufacturers.Models;
using MediatR;

namespace Internship.Business.Manufacturers.Queries.GetById
{
    public class GetManufacturerByIdQuery : IRequest<GetManufacturerIdResult>
    {
        public int Id { get; set; }

        public GetManufacturerByIdQuery(int id)
        {
            Id = id;
        }
    }
}
