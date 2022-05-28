using MediatR;

namespace Internship.Controllers.Stocks.Pagination
{
    public class GetByPageQuery: IRequest<List<StockPaginationResponse>>
    {
        public int Page { get; set; }
        public double ObjectsOnPage { get; set; }

        public GetByPageQuery(int page, double objectsOnPage)
        {
            Page = page;
            ObjectsOnPage = objectsOnPage;
        }
    }
}
