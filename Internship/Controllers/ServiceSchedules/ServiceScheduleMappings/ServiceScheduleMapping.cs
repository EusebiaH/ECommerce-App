using AutoMapper;
using Internship.Business.ServiceSchedules.Commands;
using Internship.Controllers.ServiceSchedules.ServiceScheduleModels;
using Internship.Data;

namespace Internship.Controllers.ServiceSchedules.ServiceScheduleMappings
{
    public class ServiceScheduleMapping : Profile
    {
        public ServiceScheduleMapping()
        {
            CreateMap<ServiceSchedule, GetServiceScheduleByIdResult>();
            CreateMap<PostServiceScheduleRequest, PostServiceScheduleCommand>();
            CreateMap<PostServiceScheduleResult, PostServiceScheduleCommand>();
            CreateMap<PostServiceScheduleCommand, ServiceSchedule>();
            CreateMap<UpdateServiceScheduleByIdRequest, UpdateServiceScheduleCommand>();
            CreateMap<UpdateServiceScheduleCommand, ServiceSchedule>();
            CreateMap<ServiceSchedule, UpdateServiceScheduleByIdResult>();
            CreateMap<ServiceSchedule, PostServiceScheduleResult>();

        }
    }
}
