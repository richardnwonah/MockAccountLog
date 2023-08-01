using System.ComponentModel.DataAnnotations;

namespace MockBankApi.Models
{
    public class Staging
    {
        [Key]
        public Guid Id { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Currency { get; set; }
        public double CumulativeInflow { get; set; }
    }
}
