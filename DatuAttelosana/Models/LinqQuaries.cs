using DatuAttelosana.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatuAttelosana.Models
{
    internal class LinqQuaries
    {
        private AppDbContext db = new AppDbContext();
        public void Examples() { 
            var invoiceAndClient = db.Invoices
                .Join(db.Clients,
                inv => inv.ClientId,
                client => client.Id,
                (inv, client) => new 
                { 
                    inv.InvoiceNumber,
                    client.Name,
                    inv.TotalAmount,
                    inv.DueDate
                }
                
                )
                .OrderByDescending(o => o.TotalAmount)
                .Where(o => o.TotalAmount > 100)
                .ToList();

            var result1 = db.Invoices
                .GroupJoin(db.Payments,
                inv => inv.InvoiceNumber,
                p => p.InvoiceNumber,
                (inv, ps) => new
                {
                    inv.InvoiceNumber,
                    inv.TotalAmount,
                    Payed = ps.Sum(p => p.Amount),
                    Left = inv.TotalAmount - ps.Sum(p => p.Amount)
                }

                );
        }
        public dynamic InvoiceAndClient()
        {
            var invoiceAndClient = db.Invoices
                    .Join(db.Clients,
                    inv => inv.ClientId,
                    client => client.Id,
                    (inv, client) => new
                    {
                        inv.InvoiceNumber,
                        client.Name,
                        inv.TotalAmount,
                        inv.DueDate
                    }

                    )
                    .OrderByDescending(o => o.TotalAmount)
                    .Where(o => o.TotalAmount > 100)
                    .ToList();
            return invoiceAndClient;
        }

        public dynamic UnpaidInvoices() {

            var unpaid = db.Invoices
                   .GroupJoin(db.Payments,
                   inv => inv.InvoiceNumber,
                   p => p.InvoiceNumber,
                   (inv, ps) => new
                   {
                       inv.InvoiceNumber,
                       inv.TotalAmount,
                       Paid = ps.Sum(p => p.Amount),
                       Left = inv.TotalAmount - ps.Sum(p => p.Amount)
                   }

                   ).OrderByDescending(o => o.Left)
                   .Where(o => o.Left > 0).ToList();
            return unpaid;

        }

        public dynamic ClientFinanses() { 

            var result = db.Clients
                    .GroupJoin(db.Invoices,
                        client => client.Id,
                        inv => inv.ClientId,
                        (client, invoices) => new
                        {
                            client.Name,
                            InvoiceCount = invoices.Count(),
                            TotalAmount = invoices.Sum(inv => inv.TotalAmount),
                            Paid = invoices.Sum(inv => db.Payments
                                .Where(p => p.InvoiceNumber == inv.InvoiceNumber)
                                .Sum(p => p.Amount)),
                            Left = invoices.Sum(inv => inv.TotalAmount)
                                - invoices.Sum(inv => db.Payments
                                    .Where(p => p.InvoiceNumber == inv.InvoiceNumber)
                                    .Sum(p => p.Amount))
                        })
                    .OrderByDescending(c => c.Left)
                    .ToList();

            return result;
        }
        public dynamic OverduePayments() {

            var today = DateTime.Today;

            var invoices = db.Invoices
                .Join(db.Clients,
                    inv => inv.ClientId,
                    client => client.Id,
                    (inv, client) => new
                    {
                        inv,
                        client
                    })
                .Where(x => x.inv.DueDate < today)
                .GroupJoin(db.Payments,
                    x => x.inv.InvoiceNumber,
                    p => p.InvoiceNumber,
                    (x, payments) => new
                    {
                        x.inv.InvoiceNumber,
                        x.inv.TotalAmount,
                        x.inv.DueDate,
                        x.client.Name,
                        Payed = payments.Sum(p => (int?)p.Amount) ?? 0
                    })
                .ToList();

            var result = invoices
                .Where(x => x.Payed < x.TotalAmount)
                .Select(x => new
                {
                    x.Name,
                    x.InvoiceNumber,
                    LateDays = (today - x.DueDate).Days,
                    Left = x.TotalAmount - x.Payed,
                    PaymentStatus = x.Payed == 0
                        ? "Unpaid"
                        : "Partially paid"
                })
                .OrderByDescending(x => x.LateDays)
                .ToList();

            return result;
        }

        public dynamic TopClients() {

            var today = DateTime.Today;

            var clients = db.Clients.ToList();
            var invoices = db.Invoices.ToList();
            var payments = db.Payments.ToList();

            var result = clients
                .Select(c =>
                {
                    var clientInvoices = invoices
                        .Where(i => i.ClientId == c.Id)
                        .ToList();

                    var unpaidInvoices = clientInvoices
                        .Select(i => new
                        {
                            i.InvoiceNumber,
                            Left = i.TotalAmount - payments
                                .Where(p => p.InvoiceNumber == i.InvoiceNumber)
                                .Sum(p => p.Amount)
                        })
                        .Where(i => i.Left > 0)
                        .OrderByDescending(i => i.Left)
                        .ToList();

                    return new
                    {
                        c.Name,

                        InvoiceCount = clientInvoices.Count,

                        TotalAmount = clientInvoices.Sum(i => i.TotalAmount),

                        LateInvoices = clientInvoices.Count(i =>
                            i.DueDate < today &&
                            payments
                                .Where(p => p.InvoiceNumber == i.InvoiceNumber)
                                .Sum(p => p.Amount) < i.TotalAmount),

                        BiggestUnpaidInvoiceAmount = unpaidInvoices
                            .Select(i => i.Left)
                            .FirstOrDefault()
                    };
                })
                .OrderByDescending(c => c.TotalAmount)
                .Take(3)
                .ToList();



            return result;
        }





    }
}
