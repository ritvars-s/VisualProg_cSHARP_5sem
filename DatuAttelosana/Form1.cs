using DatuAttelosana.Models;

namespace DatuAttelosana
{
    public partial class Form1 : Form
    {
        private AppDbContext db = new AppDbContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void butInvoice_Click(object sender, EventArgs e)
        {
            srcView.DataSource = db.Invoices.ToList();
        }

        private void butClient_Click(object sender, EventArgs e)
        {
            srcView.DataSource = db.Clients.ToList();
        }

        private void butPayments_Click(object sender, EventArgs e)
        {
            srcView.DataSource = db.Payments.ToList();
        }

        private void butClientInvoice_Click(object sender, EventArgs e)
        {


        }
    }
}
