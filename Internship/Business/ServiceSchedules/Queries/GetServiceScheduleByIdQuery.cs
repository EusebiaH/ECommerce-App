using Internship.Controllers.ServiceSchedules.ServiceScheduleModels;
using MediatR;

namespace Internship.Business.ServiceSchedules.Queries
{
    public class GetServiceScheduleByIdQuery:IRequest<GetServiceScheduleByIdResult>
    {
        public int Id { get; set; }
        public GetServiceScheduleByIdQuery(int id)
        {
            Id = id;
        }
    }
}
