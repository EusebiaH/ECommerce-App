using MediatR;

namespace Internship.Business.Addresses.Commands.Delete
{
    public class DeleteAddressCommand: IRequest<string>
    {
        public int Id { get; set; }  

        public DeleteAddressCommand(int id)
        {
            Id = id; 
        }



    }
}
