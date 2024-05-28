using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Librarty_Management_Sysy
{
    class dbConnection
    {
        string connectionString = "Data Source=DESKTOP-RIBJC3P;Initial Catalog=LibraryManagement;Integrated Security=True";
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;

        public void setConnection()
        {
            con = new SqlConnection(connectionString);
        }
        public void openConnection()
        {
            con.Open();
        }
        public void closeConnection()
        {
            con.Close();
        }
    }
}
