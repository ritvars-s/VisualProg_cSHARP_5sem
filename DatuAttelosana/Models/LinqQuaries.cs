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
            var result = db.Invoices
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

            var result = db.Invoices
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
        


    }
}
