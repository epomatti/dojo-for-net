namespace Dojo
{
    public class InvoiceService
    {
        private InvoiceContext _context;

        public InvoiceService(InvoiceContext context)
        {
            _context = context;
        }

        public void Save(Invoice invoice)
        {
            //TODO Validate CPF
            
            _context.Invoices.Add(invoice);
        }
    }
}