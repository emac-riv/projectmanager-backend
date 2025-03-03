using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectManager.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; } 

        [Required]
        public string Name { get; set; }

        [Required] 
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        public string Status { get; set; }

        [Column(TypeName = "decimal(18,2)")] 
        public decimal TotalPrice { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
