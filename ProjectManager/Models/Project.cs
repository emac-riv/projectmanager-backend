using System.ComponentModel.DataAnnotations;

namespace ProjectManager.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; } 

        [Required]
        public string Name { get; set; } 

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Status { get; set; }   

        public decimal TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
