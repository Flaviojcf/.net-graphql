
namespace Domain.Models
{
    public class PaymentModel
    {
        public Guid Id { get; set; }
        public decimal Value { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateOverdue { get; set; }
        public bool IsPaid { get; set; }
    }
}
