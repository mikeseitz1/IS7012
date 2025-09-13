namespace Banking.Models
{
    public class AccountHolder
    {
        public int AccountHolderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }

        //Relationship: An Account Holder can have multiple Bank Accounts
        public List<BankAccount>? BankAccounts { get; set; } = new List<BankAccount>();
    }
}
