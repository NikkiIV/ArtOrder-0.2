using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtOrder.Infrastructure.Data
{
    public class Item
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(35, MinimumLength = 5)]
        public string Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }

        [Required]
        [StringLength(250)]
        public string ImageUrl { get; set; }

        public IList<OrderedItems> OrderedItems { get; set; } = new List<OrderedItems>();


        //[Required]
        //[StringLength(30)]
        //public string Barcode { get; set; }

        //[Required]
        //[StringLength(100)]
        //public string Label { get; set; }

        //[Required]
        //[Column(TypeName = "date")]
        //public DateTime DateFrom { get; set; } = DateTime.Today;

        //[Column(TypeName = "date")]
        //public DateTime? DateTo { get; set; }

    }
}
