namespace Internship.Controllers.ProductCategoryXAttributes.Models
{
    public class GetAllProductCategoryXAttributeResult
    {
        public int Id { get; set; }
        public int ProductCategoryId { get; set; }
        public int AttributeId { get; set; }
        public string AttributeName { get; set; }   
        public string ProductCategoryName { get; set; }
    }
}
