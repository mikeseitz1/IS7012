using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitCatSeitzme.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        [Required]
        [Display(Name = "Company Name")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 50 characters.")]
        public required string CompanyName { get; set; }
        [Required]
        [Display(Name = "Company Address")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 50 characters.")]
        public required string CompanyAddress { get; set; }
        [Required]
        [Display(Name = "Company Phone")]
        [Phone]
        public required string CompanyPhone { get; set; }
        public int JobId { get; set; }
        [Required]
        [Display(Name = "Position Name")]
        public required string PositionName { get; set; }
        [Required]
        [Display(Name = "Job Location")]
        public required string JobLocation { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Job Start Date")]
        [Required]
        public DateTime? JobStartDate { get; set; }

        [Required]
        [Display(Name = "Max Salary")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(8,2)")]
        public decimal SalaryMax { get; set; }
        [Required]
        [Display(Name = "Min Salary")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(8,2)")]
        public decimal SalaryMin { get; set; }

        [Required]
        [ForeignKey("IndustryId")]
        public int IndustryId { get; set; }

        [ForeignKey("IndustryId")]
        [Required]
        public Industry Industry { get; set; } = null!;
        public List<Candidate>? Candidates { get; set; }


    }
}