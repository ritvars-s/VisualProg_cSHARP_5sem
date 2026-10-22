using Bogus;
using DatuAttelosana.Clases;
using DatuAttelosana.Enums;
using DatuAttelosana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatuAttelosana.Seeders
{
    internal class DataSeeder
    {

        public static void SeedDataBase() {
            AppDbContext db = new AppDbContext();

            var faker = new Faker();

            Client client = new Client(
                faker.Name.FullName(),
                faker.Phone.PhoneNumber(),
                faker.Random.Replace("###########")
                );

            var clientFaker = new Faker<Client>().CustomInstantiator(f => new Client(
                    faker.Name.FullName(),
                    faker.Phone.PhoneNumber(),
                    faker.Random.Replace("###########")
                    ));
            var clients = clientFaker.Generate(30);
            db.Clients.AddRange(clients);
            db.SaveChanges();

            Invoice invoice = new Invoice(
                $"VEA_{faker.Random.Number(100, 100000)}_{faker.Random.Number(100, 1000000)}",
                faker.Random.Word(),
                faker.Random.Number(1, 1000),
                faker.Date.Between(new DateTime(2025, 12, 12), new DateTime(2027, 12, 12)),
                faker.PickRandom<Client>(clients).Id
                );
            var invoiceFaker = new Faker<Invoice>().CustomInstantiator(f => new Invoice(
                $"VEA_{faker.Random.Number(100, 100000)}_{faker.Random.Number(100, 1000000)}",
                faker.Random.Word(),
                faker.Random.Number(1, 1000),
                faker.Date.Between(new DateTime(2025, 11, 11), new DateTime(2027, 11, 12)),
                faker.PickRandom<Client>(clients).Id
                ));
            var invoices = invoiceFaker.Generate(200);
            db.Invoices.AddRange(invoices);
            db.SaveChanges();

            Payment payment = new Payment(
                faker.Random.Number(1, 1000),
                faker.Random.Enum<PaymentMethod>(),
                faker.PickRandom<Invoice>(invoices).InvoiceNumber


                );
            var paymentFaker = new Faker<Payment>().CustomInstantiator(f => new Payment(
                 faker.Random.Number(1, 1000),
                 faker.Random.Enum<PaymentMethod>(),
                 faker.PickRandom<Invoice>(invoices).InvoiceNumber

                ));

            var payments = paymentFaker.Generate(200);
            db.Payments.AddRange(payments);



            db.SaveChanges();
        }

    }
}
