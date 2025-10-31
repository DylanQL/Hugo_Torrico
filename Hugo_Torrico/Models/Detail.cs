using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hugo_Torrico.Models
{
    public class Detail
    {
        public int DetailId { get; set; }
        public int Amount { get; set; }
        public float Price { get; set; }
        public float SubTotal { get; set; }
        public bool Active { get; set; }

        // Foreign Key
        public Product Product { get; set; } = null!;
        public int ProductId { get; set; }

        // Foreign Key
        public Invoice Invoice { get; set; } = null!;
        public int InvoiceId { get; set; }
    }
}
