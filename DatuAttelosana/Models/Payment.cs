using DatuAttelosana.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatuAttelosana.Models
{
    internal class Payment
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        [ForeignKey(nameof(Invoice))]
        public string InvoiceNumber { get; set; }

        public Payment() { }
        public Payment(int amount, PaymentMethod paymentMethod, string invoiceNumber) {
            Amount = amount;
            PaymentMethod = paymentMethod;
            InvoiceNumber = invoiceNumber;
        
        
        }
    }
}
