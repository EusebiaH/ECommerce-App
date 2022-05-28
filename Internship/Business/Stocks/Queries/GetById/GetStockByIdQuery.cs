using Internship.Controllers.Stocks.Models;
using MediatR;

namespace Internship.Business.Stocks.Queries.GetById
{
    public class GetStockByIdQuery: IRequest<GetStockIdResult>
    {
        public int Id { get; set; }

        public GetStockByIdQuery(int id)
        {
            Id = id;
        }
    }
}
