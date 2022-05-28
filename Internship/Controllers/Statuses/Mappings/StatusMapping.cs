using AutoMapper;
using Internship.Business.Statuses.Commands.Create;
using Internship.Business.Statuses.Commands.Update;
using Internship.Data;
using Internship.Data.Statuses;

namespace Internship.Controllers.Statuses.Mappings
{
    public class StatusMapping:Profile
    {
        public StatusMapping()
        {
            CreateMap<StatusRequest, CreateStatusCommand>();
            CreateMap<CreateStatusCommand, Status>();
            CreateMap<Status, StatusResult>();
            CreateMap<UpdateStatusRequest, UpdateStatusCommand>();
            CreateMap<UpdateStatusCommand, Status>();
            CreateMap<Status, GetStatusResult>();
            CreateMap<Status, GetStatusByIdResult>();   
        }
    }
}
