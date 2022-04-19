using ArtOrder.Infrastructure.Data.Identity;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtOrder.Infrastructure.Data
{
    public class Commission
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(30)]
        public string Type { get; set; }

        [Required]
        [StringLength(30)]
        public string Details { get; set; }

        [Required]
        [StringLength(160)]
        public string Description { get; set; }

        [Required]
        [StringLength(30)]
        public string Status { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        //[StringLength(36)]
        public string UserId { get; set; }

        [Required]
        public virtual ApplicationUser User { get; set; }

        public string? FeedBack { get; set; }
    }
}
