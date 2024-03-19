using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Revenue
    {
        [Key]
        public int RevenueID { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Earnings { get; set; }
    }
}
