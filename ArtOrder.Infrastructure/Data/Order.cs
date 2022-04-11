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
    public class Order
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid SaleId { get; set; }

        [ForeignKey(nameof(SaleId))]
        public Sale Sales { get; set; }

        public IList<OrderDetail> OrderDetails { get; set; }
    }
}
