using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using Z_PayPalStepLibrary.contracts;

namespace Z_PayPalStepLibrary.tabletransformations
{
    [Binding]
    public class Transformations
    {
        [StepArgumentTransformation]
        public PaymentRequest PaymentRequest(Table table)
        {
            // zero total amount if its decimal parse fails
            decimal total = 0;
            try
            {
                total = decimal.Parse(table.Rows.FirstOrDefault()["total"]);
            }
            catch(Exception ex)
            {
                // do nothing
            }

            var paymentRequest = new PaymentRequest
            {
                intent = table.Rows.FirstOrDefault()["intent"],
                redirect_urls = new RedirectUrl
                {
                    return_url = table.Rows.FirstOrDefault()["return_url"],
                    cancel_url = table.Rows.FirstOrDefault()["cancel_url"]
                },
                payer = new Payer
                {
                    payment_method = table.Rows.FirstOrDefault()["payment_method"],
                },
                transactions = new List<Transaction>
                {
                    new Transaction
                    {
                        amount = new Amount
                        {
                            total = total,
                            currency = table.Rows.FirstOrDefault()["currency"]
                        }
                    }
                }
            };

            return paymentRequest;
        }
    }
}
