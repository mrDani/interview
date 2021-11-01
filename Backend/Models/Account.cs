using System.ComponentModel.DataAnnotations;


namespace Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        public AccountType accountTypes { get; set; }

    }

    public class AccountType
    {
        [Key]
        public string DebitAccount { get; set; }
        public string DepositAccount { get; set; }
    }
}