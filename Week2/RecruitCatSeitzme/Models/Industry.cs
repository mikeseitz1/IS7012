using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitCatSeitzme.Models
{
    public class Industry
    {
        [Key]
        public int IndustryId { get; set; }

        [Display(Name = "Industry Name")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 50 characters.")]
        public required string IndustryName { get; set; }

        //Relationship: One Industry to Many Candidates and Companies//
        public ICollection<Candidate>? Candidates { get; set; }
        public ICollection<Company>? Companies { get; set; }
    }
}