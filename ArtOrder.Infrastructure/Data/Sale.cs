using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtOrder.Infrastructure.Data
{
    public class Sale
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required()]
        [StringLength(20)]
        public string CustomerNumber { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        //[StringLength(20)]
        //public string? Identifier { get; set; }

        [StringLength(200)]
        public string? Address { get; set; }

        //[StringLength(20)]
        //public string? LoyaltyCard { get; set; }

        public IList<Order> Orders { get; set; } = new List<Order>();
    }
}
