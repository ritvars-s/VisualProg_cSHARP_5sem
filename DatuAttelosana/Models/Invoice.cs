using Bogus.DataSets;
using DatuAttelosana.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatuAttelosana.Models
{
    internal class Invoice
    {
        [Key]
        public string InvoiceNumber { get; set; }
        public string Title { get; set; }
        public int TotalAmount { get; set; }
        public DateTime DueDate { get; set; }

        public int ClientId { get; set; }

        public Invoice() { }
        public Invoice(string invoiceNumber, string title, int totalAmount, DateTime dueDate, int clientId) {
            InvoiceNumber = invoiceNumber;
            Title = title;
            TotalAmount = totalAmount;
            DueDate = dueDate;
            ClientId = clientId;
        }
    }
}
