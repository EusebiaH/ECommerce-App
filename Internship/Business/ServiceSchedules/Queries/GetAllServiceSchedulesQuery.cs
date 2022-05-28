using Internship.Data;
using MediatR;

namespace Internship.Business.ServiceSchedules.Queries
{
    public class GetAllServiceSchedulesQuery:IRequest<List<ServiceSchedule>>
    {
    }
}
