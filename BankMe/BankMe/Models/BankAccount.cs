using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankMe.Models
{
    public class BankAccount
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int AccountHolderId { get; set; }
        
        [Display(Name = "Account Number")]
        [Required]
        public string AccountNumber { get; set; }
        
        [Required]
        [Display(Name = "Routing Number")]
        public string RoutingNumber { get; set; }
        [Required]
        [Display(Name = "Account Name")]
        public string AccountName { get; set; }
        [Required]
        [Display(Name = "Account Type")]
        public string AccountType { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; }

        [DataType(DataType.Date)]
        [Required]
        [Display(Name = "Last Deposit Date")]
        public DateTime LastDepositDate { get; set; }

        [DataType(DataType.Date)]
        [Required]
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }

        //Relationship: An account belongs to an Account Holder//

        [ForeignKey("AccountHolderId")]
        [Required]
        public AccountHolder AccountHolder { get; set; }
    }

}

