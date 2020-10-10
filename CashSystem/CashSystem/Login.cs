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
            SqlDataAdapter sda = new SqlDataAdapter(queries.userCredQuery("Select", txtUsername.Text, txtPassword.Text), connection.sqlCon);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            try
            {
                /// conn.checkConnectionState(); //<1---- nasa connection.cs
                if (dataTable.Rows.Count == 1)
                {

                    this.Hide();
                    AllForms.adminDashBoard.Show();

                }
                else if (txtPassword.Text == "" || txtUsername.Text == "")
                {
                    MessageBox.Show("Username or Password is empty.");
                }
                else
                {
                    MessageBox.Show("Please contact the admin to check");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Form Error : " + ex.Message);
            }

        }
    }
}
