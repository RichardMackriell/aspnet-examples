namespace Shop.Entities
{
    public class Cart
    {
        public int CartId { get; set; }

        public Customer Customer { get; set; }
        public ICollection<Product> Products { get; set;}
    }
}
