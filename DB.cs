using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class DB
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-OR7C660\SQLEXPRESS;Initial Catalog=C# DB;Integrated Security=True");
        public void openConnetcion()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnetcion()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
