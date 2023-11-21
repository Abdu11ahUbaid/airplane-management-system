using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagementSystem
{
    internal class configuration
    {
        String ConnectionStr = @"Data Source=(local);Initial Catalog=AirplaneManagementSystem;Integrated Security=True";
        SqlConnection con;
        private static configuration _instance;
        public static configuration getInstance()
        {
            if (_instance == null)
                _instance = new configuration();
            return _instance;
        }
        private configuration()
        {
            con = new SqlConnection(ConnectionStr);
            con.Open();
        }
        public SqlConnection getConnection()
        {
            return con;
        }
    }
}
