using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public Cart Cart { get; set; }
    }
}
