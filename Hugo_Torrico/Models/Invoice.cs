using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hugo_Torrico.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public DateTime Date { get; set; }
        public string InvoiceNumber { get; set; } = string.Empty;
        public float Total { get; set; }
        public bool Active { get; set; }

        // Foreign Key
        public Customer Customer { get; set; } = null!;
        public int CustomerId { get; set; }

        public ICollection<Detail> Details { get; set; } = new List<Detail>();
    }
}
