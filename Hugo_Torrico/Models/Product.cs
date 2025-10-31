using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hugo_Torrico.Models
{
    [Table("Products")]
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public float Price { get; set; }

        public ICollection<Detail> Details { get; set; } = new List<Detail>();
    }
}
