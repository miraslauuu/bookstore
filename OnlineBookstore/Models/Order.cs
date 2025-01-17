namespace OnlineBookstore.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public int TotalAmount { get; set; }
        public required string Status { get; set; }
    }
}
