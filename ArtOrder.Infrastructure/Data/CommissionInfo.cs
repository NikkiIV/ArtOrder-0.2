using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtOrder.Infrastructure.Data
{
    public class CommissionInfo
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(30)]
        public string TypeOfCommission { get; set; }

        [Required]
        public DateTime CommissionNumberDate { get; set; }

        [StringLength(30)]
        public string Session { get; set; }

        public DateTime SessionDate { get; set; }

        [Required]
        //[StringLength(36)]
        [ForeignKey(nameof(CommissionOrder))]
        public Guid CommissionOrderId { get; set; }

        [Required]
        public CommissionOrder CommissionOrder { get; set; }        
    }
}
