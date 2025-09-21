using System.ComponentModel.DataAnnotations;

namespace BankMe.Models
{
    public class AccountHolder
    {
        public AccountHolder()
        {
            BankAccounts = new List<BankAccount>();
        }

        [Key]
        public int AccountHolderId { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Address")]
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Zip code must be 5 digits")]
        public string ZipCode { get; set; }

        [Display(Name = "Phone Number")]
        [Phone]
        public string PhoneNumber { get; set; }

        [Display(Name = "Social Security Number")]
        [RegularExpression(@"^\d{3}-\d{2}-\d{4}$", ErrorMessage = "SSN must be in the format XXX-XX-XXXX")]
        [StringLength(11, MinimumLength = 9, ErrorMessage = "SSN must be exactly 11 characters including dashes")]
        [Required(ErrorMessage = "Social Security Number is required")]
        public string SocialSecurityNumber { get; set; }
        public string FullName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }


        //Relationship: An Account Holder can have multiple Bank Accounts
        public ICollection<BankAccount> BankAccounts { get; set; }
    }

}

