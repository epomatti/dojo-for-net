using System.Data.SqlClient;

namespace YellowBelt.Exercises.Invoice
{
    public class InvoiceDAO
    {

        public virtual Invoice FindInvoice(int id)
        {
            SqlConnection conn = new SqlConnection("Data Source=;Initial Catalog=;Persist Security Info=True;User ID=;Password=");
            conn.Open();

            SqlCommand command = new SqlCommand("Select id from [Invoice] where id=@id", conn);
            command.Parameters.AddWithValue("@id", "id");

            /*
            Retrieves 
            */
            return new Invoice();
        }
    }
}