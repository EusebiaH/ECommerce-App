using Internship.Data.Statuses;
using MediatR;

namespace Internship.Business.Statuses.Queries.GetById
{
    public class GetStatusByIdQuery:IRequest<GetStatusByIdResult>
    {
        public int Id { get; set; }

        public GetStatusByIdQuery(int id)
        {
            Id = id;
        }
    }
}
