using System.Collections.Generic;

namespace YellowBelt.Exercises.Invoice
{

    public class Invoice
    {
        List<InvoiceItem> items = new List<InvoiceItem>();

        public virtual int GetTotal()
        {
            int total = 0;
            foreach (var item in items)
            {
                total += item.Value;
            }
            return total;
        }
    }

    public class InvoiceItem
    {
        public int Value { get; set; }

        public InvoiceItem(int Value)
        {
            this.Value = Value;
        }

    }

}