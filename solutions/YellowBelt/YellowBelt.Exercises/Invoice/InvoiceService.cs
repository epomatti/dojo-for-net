namespace YellowBelt.Exercises.Invoice
{
    public class InvoiceService
    {

        private InvoiceDAO dao;

        public InvoiceService(InvoiceDAO dao)
        {
            this.dao = dao;
        }

        public int GetInvoiceTotalValue(int id)
        {
            Invoice invoice = dao.FindInvoice(id);
            return invoice.GetTotal();
        }

    }

}