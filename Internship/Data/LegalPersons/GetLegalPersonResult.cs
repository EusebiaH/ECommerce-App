using MediatR;

namespace Internship.Data.LegalPersons
{
    public class GetLegalPersonResult
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public string CUI { get; set; }
    }
}
