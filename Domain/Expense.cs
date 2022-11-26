namespace Domain
{
    public class Expense
    {
        public Guid Id { get; set; }
        public string expenseName { get; set; }
        public string business { get; set; }
        public float amount { get; set; }
        public string paymentStatus { get; set; }
    }
}