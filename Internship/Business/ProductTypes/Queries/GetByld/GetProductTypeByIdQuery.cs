using Internship.Data.ProductsType;
using MediatR;

namespace Internship.Business.ProductTypes.Queries.GetByld
{
    public class GetProductTypeByIdQuery : IRequest<List<GetProductTypeByIdResult>>
    {
        public int Id { get; set; }

        public GetProductTypeByIdQuery(int id)
        {
            Id = id;
        }
    }
}