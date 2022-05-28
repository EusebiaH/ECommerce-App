namespace Internship.Data
{
    public class Attribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public int? AttributeTypeId { get; set; }
        public virtual AttributeType? AttributeType { get; set; }
    }
}
