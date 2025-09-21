using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Banking.Models
{
    public class BankAccount
    {
        [Key]
        public int Id { get; set; }
        public int AccountHolderId { get; set; }
        [Display(Name = "Account Number")]
        [Required]
        public string AccountNumber { get; set; }
        [Required]
        public string RoutingNumber { get; set; }
        [Required]
        public string AccountName { get; set; }
        [Required]
        public string AccountType { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastDepositDate { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime CreatedDate { get; set; }

        //Relationship: An account belongs to an Account Holder//

        [ForeignKey("AccountHolderId")]
        [Required]
        public AccountHolder AccountHolder { get; set; }
    }
}
