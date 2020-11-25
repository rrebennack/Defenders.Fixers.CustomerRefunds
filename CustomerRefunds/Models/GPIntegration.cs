namespace CustomerRefunds.Models
{
    public class GPIntegration
    {
        public string BatchID
        {
            get; set;
        }

        public string Description
        {
            get; set;
        }

        public string PartnerName
        {
            get; set;
        }

        public string PayReference
        {
            get; set;
        }

        public string GPVendorId
        {
            get; set;
        }

        public string DocumentNumber
        {
            get; set;
        }

        public string VoucherNumber
        {
            get; set;
        }
        
        public decimal Amount
        {
            get; set;
        }
        
        public decimal PurchaseAmount
        {
            get; set;
        }
        
        public string DebitDistType
        {
            get; set;
        }
        
        public string CreditDistType
        {
            get; set;
        }
        
        public string AccntNum
        {
            get; set;
        }
        
        public string CreditAcctNum
        {
            get; set;
        }
    }
}