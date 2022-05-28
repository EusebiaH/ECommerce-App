using AutoMapper;
using Internship.Business.Addresses.Commands.Create;
using Internship.Business.Addresses.Commands.Update;
using Internship.Controllers.Addresses.Models;
using Internship.Data;

namespace Internship.Controllers.Addresses.Mappings
{
    public class AddressMapping: Profile
    {

        public AddressMapping()
        {

            CreateMap<PostAddressRequest, PostAddressCommand>();
            CreateMap<PostAddressCommand, Address>();
            CreateMap<Address, PostAddressResult>();
            CreateMap<UpdateAddressRequest, UpdateAddressCommand>();
            CreateMap<UpdateAddressCommand, Address>();
            CreateMap<Address , UpdateAddressResult>();   


        }



    }
}
