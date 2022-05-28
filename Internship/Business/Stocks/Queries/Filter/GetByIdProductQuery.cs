using Internship.Controllers.Stocks.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.Stocks.Queries.Filter
{
    public class GetByIdProductQuery : IRequest<GetStockIdResult>
    {
        public int ProductId { get; set; }  

        public GetByIdProductQuery(int id)
        {
            ProductId = id;
        }

    }
}
