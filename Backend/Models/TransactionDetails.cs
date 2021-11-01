using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class TransactionDetails
    {
        [Key]
        public int Id { get; set; }
        public string Depositor { get; set; }
        public string Beneficiary { get; set; }
        public int BalanceEnquiry { get; set; }
        public string Value { get; set; }
        public DateTime Trandate { get; set; }
        public string status { get; set; }
    }

}