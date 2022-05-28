using MediatR;

namespace Internship.Business.ServiceSchedules.Commands
{
    public class ServiceScheduleDeleteCommand : IRequest<string>
    {
        public int Id { get; set; }
        public ServiceScheduleDeleteCommand(int id)
        {
            Id = id;
        }
    }
}
