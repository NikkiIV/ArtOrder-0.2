using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtOrder.Infrastructure.Data
{
    public class Products
    {
        [Key]
        [StringLength(64)]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(35, MinimumLength = 5)]
        public string Name { get; set; }
                
        [Column(TypeName = "decimal(18,2)")]
        public decimal Quantity { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [StringLength(250)]
        public string ImageUrl { get; set; }

        //------CATEGORY
        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Categories Category { get; set; }
        //------------
               
        [Required]
        [Range(minimum:0,maximum:double.MaxValue)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        //-----SALE
        [Required]
        [ForeignKey(nameof(Sale))]
        public Guid SaleId { get; set; }

        [Required]
        public Sales Sale { get; set; }
       
    }
}
