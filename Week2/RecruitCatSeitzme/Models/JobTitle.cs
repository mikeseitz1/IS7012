using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitCatSeitzme.Models
{
    public class JobTitle
    {
        [Key]
        public int JobTitleId { get; set; }

        [Required]
        [Display(Name = "Job Name")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Job Name must be between 1 and 50 characters.")]
        public required string JobName { get; set; }

        [Display(Name = "Minimum Salary")]
        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(8,2)")]
        public decimal SalaryMin { get; set; }
        [Display(Name = "Maximum Salary")]
        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(8,2)")]
        public decimal SalaryMax { get; set; }

        [Required]
        [Display(Name = "Job Description")]
        [StringLength(500, MinimumLength = 1, ErrorMessage = "Description must be between 1 and 500 characters.")]
        public required string JobDescription { get; set; }

        public List<Candidate>? Candidates { get; set; }

    }
}