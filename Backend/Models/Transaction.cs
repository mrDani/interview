using System.ComponentModel.DataAnnotations;


namespace Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public string Deposit { get; set; }
        public string Withdrawl { get; set; }
        public int BalanceEnquiry { get; set; }

    }
}