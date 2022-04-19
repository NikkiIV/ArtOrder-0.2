using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtOrder.Infrastructure.Data
{
    public class SalesProducts
    {
        [Key]
        [StringLength(64)]
        public string SaleId { get; set; }

        [ForeignKey(nameof(SaleId))]
        public Sales Sale { get; set; }

        [Required]
        [Range(minimum: 0, maximum: double.MaxValue)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [StringLength(64)]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Products Product { get; set; }
    }
}
