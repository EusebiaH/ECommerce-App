using Internship.Controllers.Addresses.Models;
using MediatR;

namespace Internship.Business.Addresses.Commands.Create
{
    public class PostAddressCommand: IRequest<PostAddressResult>
    {
        public int UserId { get; set; }

        public int CountryId { get; set; }

        public int CountyId { get; set; }

        public int CityId { get; set; }

        public string Street { get; set; }

        public string OtherDetails { get; set; }





    }
}
