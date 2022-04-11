using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtOrder.Infrastructure.Data
{
    public class OrderedItems
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        
        [Required]
        [StringLength(5)]
        public string Number { get; set; }

        [Required]
        [StringLength(5)]
        public string Section { get; set; }

        public bool IsInUse { get; set; } = true;

        public int ItemsCount { get; set; } = 0;

        public Guid ItemId { get; set; }

        [ForeignKey(nameof(ItemId))]
        public Item Item { get; set; }
    }
}
