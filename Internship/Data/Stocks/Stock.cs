using Internship.Data;

namespace Internship.Data
{
    public class Stock
    {   
        public int Id { get; set; }    
        public  DateTime InvoiceDate { get; set; }
        public int ProductId { get; set; }  
        public int Quantity { get; set; }
        public double PurchasePrice { get; set; }

        public virtual Product Product { get; set; }
    }
}
