using CashSystem.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashSystem.general
{
    public partial class CustomerAccountTransaction : Form
    {
        public CustomerAccountTransaction()
        {
            InitializeComponent();
        }

        private void CustomerBoard_Load(object sender, EventArgs e)
        {
            txtBalance.Enabled = false;
            txtName.Enabled = false;
            

            //check if dollar or peso
            /*try
            {
                connection.sqlCon.Open();

                OleDbCommand command2 = new OleDbCommand();
                command2.CommandText = "SELECT isatm,ispassbook,ispeso,isdollar FROM clientproftbl where accnum= '" + Searching.AccNumber + "'";
                command2.Connection = connection.sqlCon;
                OleDbDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                   
                }

                connection.sqlCon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting Peso Dollar " + ex, "ERROR");
            }*/
            //getting current balance
            try
            {
                connection.sqlCon.Open();

                OleDbCommand command = new OleDbCommand();
                command.CommandText = "SELECT currentbalance FROM customerbalance where accnum= '" + Searching.AccNumber + "'";
                command.Connection = connection.sqlCon;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtBalance.Text = String.Format("{0:n0}",reader["currentbalance"]);
                    Searching.CurrentBalance = Int32.Parse(reader["currentbalance"].ToString());
                }

                connection.sqlCon.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error getting Current Balance " +ex, "ERROR");
            }

            //getting name
            try
            {
                connection.sqlCon.Open();

                OleDbCommand command1 = new OleDbCommand();
                command1.CommandText = "SELECT lname,fname,mname,suffix FROM mandatoryinfotbl where accnum= '" + Searching.AccNumber + "'";
                command1.Connection = connection.sqlCon;
                OleDbDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
                {
                    txtName.Text = reader1["lname"].ToString().ToUpper() + ", " + reader1["fname"].ToString().ToUpper() + 
                        ", " + reader1["mname"].ToString().ToUpper() + " " + reader1["suffix"].ToString().ToUpper();
                }

                connection.sqlCon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting Name " + ex, "ERROR");
            }

        }

        private void btnViewDeposit_Click(object sender, EventArgs e)
        {
           
            AllForms.depositTransaction.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
          
        }

        private void btnViewWithdrawal_Click(object sender, EventArgs e)
        {
            AllForms.withdrawalTransaction.Show();
            this.Hide();
        }
    }
}
