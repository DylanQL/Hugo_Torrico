using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hugo_Torrico.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string DocumentNumber { get; set; } = string.Empty;

        public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
    }
}
