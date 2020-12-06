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
    public partial class WithdrawForm : Form
    {
        public WithdrawForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.sqlCon.Open();
            try
            {

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection.sqlCon;
                String particulars = "withdraw " + txtAmountDeposit.Text;
                command.CommandText = "INSERT INTO customerwithdraw (accnum,amountwithdraw,particular,newbalance,datetransact)" +
                    "VALUES('" + Searching.AccNumber + "','" + int.Parse(txtAmountDeposit.Text) + "','" + particulars + "','" + (Searching.CurrentBalance - int.Parse(txtAmountDeposit.Text)) + "','" + DateTime.Now + "')";
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding to customer withdraw table " + ex, "Error");
            }

            //Update customer balance
            try
            {

                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection.sqlCon;

                command1.CommandText = "UPDATE customerbalance SET currentbalance= currentbalance-'" + int.Parse(txtAmountDeposit.Text) + "', asof='" + DateTime.Now + "' WHERE accnum = '"+Searching.AccNumber+"'";
                command1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updateing to customer balance " + ex, "Error");
            }
            connection.sqlCon.Close();

            MessageBox.Show(txtAmountDeposit.Text + " is successfully withdraw into the account", "SUCCESS");
            this.Hide();
            txtAmountDeposit.Text = "";
            CustomerBoardAccountTransaction cus = new CustomerBoardAccountTransaction();
            cus.Show();
        }
    }
}
