using System;

namespace GestorDeCobranza.Model
{
    public class Invoice
    {
        public string Number { get; set; }
        public string Date { get; set; }
        public decimal Total { get; set; }
        public List<InvoiceItem> SubItems { get; set; } = new();
        public bool IsOpen { get; set; } = false;
    }
}
