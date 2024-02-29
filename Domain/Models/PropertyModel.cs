
namespace Domain.Models
{
    public class PropertyModel
    {

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public decimal Value { get; set; }

        public string Family { get; set; }

        public ICollection<PaymentModel> Payments { get; set; }
    }
}
