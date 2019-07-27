using System.Collections.Generic;


namespace Z_PayPalStepLibrary.contracts
{
    public class PaymentRequest
    {
        public string intent { get; set; }
        public RedirectUrl redirect_urls { get; set; }
        public Payer payer { get; set; }
        public List<Transaction> transactions { get; set; }
    }

    public class Transaction
    {
        public Amount amount { get; set; }
    }

    public class Amount
    {
        public decimal total { get; set; }
        public string currency { get; set; }

    }

    public class Payer
    {
        public string payment_method { get; set; }
    }

    public class RedirectUrl
    {
        public string return_url { get; set; }
        public string cancel_url { get; set; }
    }
}

