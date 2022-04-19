﻿using ArtOrder.Infrastructure.Data.Identity;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtOrder.Infrastructure.Data
{
    public class CommissionOrder
    {   
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        [StringLength(160)]
        public string Description { get; set; }

        public ICollection<CommissionInfo> CommissionInfos { get; set; } = new List<CommissionInfo>();
    }
}
