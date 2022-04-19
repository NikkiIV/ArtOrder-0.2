using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ArtOrder.Infrastructure.Data.Identity
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(50)]
        public string? FirstName { get; set; }

        [StringLength(50)]
        public string? LastName { get; set; }

        //public ICollection<Commission> Commissions { get; set; } = new List<Commission>();
        //public ICollection<CommissionOrder> Orders { get; set; } = new List<CommissionOrder>();
    }
}
