using System.Data.SqlClient;

namespace MyWebBlog.Data.Sql.Database.Setup
{
    public class DatabaseConnection
    {       
        public SqlConnection ConnectDb()
        {
            var dbConnectionString = "Data Source=DESKTOP-LH42MQ0;Initial Catalog=Blog;Integrated Security=True";
            var connection = new SqlConnection(dbConnectionString);
            connection.Open();

            return connection;
        }
    }
}
