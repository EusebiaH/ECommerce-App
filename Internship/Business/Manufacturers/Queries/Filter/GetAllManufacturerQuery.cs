using Internship.Data;
using MediatR;

namespace Internship.Business.Manufacturers.Queries.Filter
{
    public class GetAllManufacturerQuery : IRequest<List<Manufacturer>>
    {
    }
}
