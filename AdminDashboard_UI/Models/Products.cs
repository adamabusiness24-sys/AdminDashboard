using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminDashboard_UI.Models
{
    [Table("Products")]
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string? ProductName { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string? color { get; set; }
    }
}
