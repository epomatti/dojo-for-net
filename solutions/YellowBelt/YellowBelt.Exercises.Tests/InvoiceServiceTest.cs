using Xunit;
using YellowBelt.Exercises.Invoice;

namespace YellowBelt.Exercises.Tests
{
    public class InvoiceServiceTest
    {

        private InvoiceService _service;

        public InvoiceServiceTest(InvoiceService service)
        {
            this._service = service;
        }

        [Fact]
        public void GetInvoiceTotalValue()
        {
            // TODO: Implement
        }
    }
}
