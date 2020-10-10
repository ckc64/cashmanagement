using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashSystem
{
    public static class connection
    {
        public static SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Soft Eng System\CashSystem\CashSystem\database\cashSystemDB.mdf;Integrated Security=True;Connect Timeout=30");

        //check if open ba ang connection
        public static void checkConnectionState()
        {
            if (sqlCon.State != System.Data.ConnectionState.Open)
            {
                sqlCon.Close();
                sqlCon.Open();
            }
        }
    }
}
