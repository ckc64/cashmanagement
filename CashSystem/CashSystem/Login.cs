using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CashSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ///connection is set as public static on the connection.cs class for easy access and 
            ///to prevent typing lots of OLEDB DATA
            try {
                connection.sqlCon.Open();

                connection.command.Connection = connection.sqlCon;
                connection.command.CommandText = "Select * from users where username='"+txtUsername.Text+"' and userpass='"+txtPassword.Text+"'";
                connection.reader  = connection.command.ExecuteReader();

                int count = 0;
                while (connection.reader.Read())
                {
                    count++;

                }
                if(count == 1)
                {

                    MessageBox.Show("user and pass correct");
                    this.Hide();
                    AllForms.adminDashBoard.Show();
                }
                else
                {
                    MessageBox.Show("user and pass incorrect");
                }
                connection.sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Login Form " + ex);
            }
         
           
        }
    }
}
