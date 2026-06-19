using DonorNexus.Models;
using System.Data;
using System.Data.SqlClient;

namespace DonorNexus.DAL
{
    public class ContactDAL
    {
        public void AddMessage(ContactMessage message)
        {
            DatabaseHelper db =new DatabaseHelper();

            SqlConnection con = db.GetConnection();

            con.Open();

            string query =
                @"INSERT INTO ContactMessages
                (
                    SenderName,
                    SenderEmail,
                    Subject,
                    MessageText,
                    SentDate
                )
                VALUES
                (
                    @SenderName,
                    @SenderEmail,
                    @Subject,
                    @MessageText,
                    @SentDate
                )";

            SqlCommand cmd =  new SqlCommand(query, con);

            cmd.Parameters.AddWithValue(
                "@SenderName",
                message.SenderName.Trim());

            cmd.Parameters.AddWithValue(
                "@SenderEmail",
                message.SenderEmail.Trim());

            cmd.Parameters.AddWithValue(
                "@Subject",
                message.Subject.Trim());

            cmd.Parameters.AddWithValue(
                "@MessageText",
                message.MessageText.Trim());

            cmd.Parameters.AddWithValue(
                "@SentDate",
                message.SentDate);

            cmd.ExecuteNonQuery();

            con.Close();
        }

        public DataTable GetMessages()
        {
            DatabaseHelper db = new DatabaseHelper();

            SqlConnection con =db.GetConnection();

            string query =
                @"SELECT
                    SenderName,
                    SenderEmail,
                    Subject,
                    MessageText,
                    SentDate
                  FROM ContactMessages";

            SqlDataAdapter adapter =new SqlDataAdapter(query, con);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
    }
}
