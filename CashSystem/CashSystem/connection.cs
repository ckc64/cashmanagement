using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashSystem
{
    public static class connection
    {
        public static OleDbConnection sqlCon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Github\cashmanagement\CashSystem\CashSystem\cashsystem.accdb;Persist Security Info=False;");
     
        public static OleDbDataReader reader;
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
