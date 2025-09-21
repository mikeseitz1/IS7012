using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitCatSeitzme.Models
{
    public class Candidate
    {
        [Key]
        public int CandidateId { get; set; }

        [Display(Name = "First Name")]
        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 50 characters.")]
        public required string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 50 characters.")]
        public required string LastName { get; set; }

        [EmailAddress]
        [Required]
        public required string Email { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        [Required]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Address")]
        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 50 characters.")]
        public required string StreetAddress { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 50 characters.")]
        public required string City { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 50 characters.")]
        public required string State { get; set; }

        [Display(Name = "Zip Code")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Zip code must be 5 digits")]
        [Required]
        public required string ZipCode { get; set; }

        [Display(Name = "Phone Number")]
        [Phone]
        [Required(ErrorMessage = "Phone number is required")]
        public required string PhoneNumber { get; set; }

        [Display(Name = "Social Security Number")]
        [RegularExpression(@"^\d{3}-\d{2}-\d{4}$", ErrorMessage = "SSN must be in the format XXX-XX-XXXX")]
        [StringLength(11, MinimumLength = 9, ErrorMessage = "SSN must be exactly 11 characters including dashes")]
        [Required(ErrorMessage = "Social Security Number is required")]
        public required string SocialSecurityNumber { get; set; }

        public string FullName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }

        [Required]
        [Display(Name = "Resume URL")]
        [Url]
        public required string ResumeUrl { get; set; }

        [Required]
        [Display(Name = "Cover Letter")]
        [StringLength(500, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 500 characters.")]
        public required string CoverLetter { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Application Date")]
        public DateTime ApplicationDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Target Start Date")]
        public DateTime? TargetStart { get; set; }

        [Required]
        public string? Status { get; set; }

        public int? IndustryId { get; set; }
        public int? CompanyId { get; set; }

        //Relationship: One Industry to Many Candidates//
        [ForeignKey("CompanyId")]
        public Company? Company { get; set; }

        //Relationship: One Industry to Many Candidates//
        [ForeignKey("IndustryId")]
        public Industry? Industry { get; set; }

    }
}