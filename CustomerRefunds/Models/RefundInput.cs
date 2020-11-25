namespace CustomerRefunds.Models
{
    public class RefundInput
    {
        public string CustomerID
        {
            get; set;
        }

        public decimal Amount
        {
            get; set;
        }
    }
}