using System;

namespace GestorDeCobranza.Model
{
    public class Deudor
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Initials { get; set; } = string.Empty;
        public string IdNumber { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Debt { get; set; }
        public string Period { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string StatusText { get; set; } = string.Empty;
        public string Priority { get; set; } = string.Empty;
        public string PriorityText { get; set; } = string.Empty;
        public string LastContact { get; set; } = string.Empty;
        public string ContactMethod { get; set; } = string.Empty;
        public string AvatarColor { get; set; } = string.Empty;
        public bool IsExpanded { get; set; }
        public List<Invoice> Invoices { get; set; } = new();

        public void GenerateInvoices()
        {
            Invoices = new List<Invoice>
            {
                CreateInvoice("INV-2847", "Jul 2023", 0.2m),
                CreateInvoice("INV-2912", "Ago 2023", 0.2m),
            };
        }

        private Invoice CreateInvoice(string number, string date, decimal percentage)
        {
            decimal invoiceTotal = Debt * percentage;

            return new Invoice
            {
                Number = number,
                Date = date,
                Total = invoiceTotal,
                SubItems = new List<InvoiceItem>
                {
                    new InvoiceItem
                    {
                        Name = "Llamadas Telefónicas",
                        Icon = "fa-phone",
                        Amount = invoiceTotal * 0.25m,
                    },
                    new InvoiceItem
                    {
                        Name = "Internet Banda Ancha 100MB",
                        Icon = "fa-wifi",
                        Amount = invoiceTotal * 0.40m,
                    },
                    new InvoiceItem
                    {
                        Name = "TV por Cable Premium",
                        Icon = "fa-tv",
                        Amount = invoiceTotal * 0.35m,
                    },
                },
            };
        }
    }
}
