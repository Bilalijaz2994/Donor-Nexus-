using System.Configuration;
using System.Data.SqlClient;

namespace DonorNexus.DAL
{
    public class DatabaseHelper
    {
        private readonly string connectionString;

        public DatabaseHelper()
        {
            ConnectionStringSettings configuredConnection =
                ConfigurationManager.ConnectionStrings["DonorNexusDB"];

            if (configuredConnection != null &&
                !string.IsNullOrWhiteSpace(configuredConnection.ConnectionString))
            {
                connectionString = configuredConnection.ConnectionString;
            }
            else
            {
                connectionString =
                    "Data Source=localhost\\SQLEXPRESS;Initial Catalog=DonorNexusDB;Integrated Security=True;TrustServerCertificate=True";
            }
        }

        public SqlConnection GetConnection()
        {
            SqlConnection connection =
                new SqlConnection(connectionString);

            return connection;
        }
    }
}
