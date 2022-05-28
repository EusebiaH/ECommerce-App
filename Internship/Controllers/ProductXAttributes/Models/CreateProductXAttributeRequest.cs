namespace Internship.Controllers.ProductXAttributes.Models
{
    public class CreateProductXAttributeRequest
    {
        public int ProductId { get; set; }
        public int AttributeId { get; set; }
        public double Value { get; set; }
    }
}
