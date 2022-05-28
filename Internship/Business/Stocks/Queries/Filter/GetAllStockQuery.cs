using Internship.Data;
using MediatR;

namespace Internship.Business.Stocks.Queries.Filter
{
    public class GetAllStockQuery: IRequest<List<Stock>>
    {
    }
}
