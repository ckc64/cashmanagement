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
    public partial class WithdrawalTransaction : Form
    {
        public WithdrawalTransaction()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllForms.withdrawForm.Show();
        }

        private void WithdrawalTransaction_Load(object sender, EventArgs e)
        {
            connection.sqlCon.Open();
            try
            {

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection.sqlCon;

                command.CommandText = "SELECT amountdep AS AMOUNT_DEPOSITED, particular AS PARTICULAR, newbalance AS NEW_BALANCE, datetransact AS DATE_TRANSACT FROM customerwithdraw WHERE accnum='" + Searching.AccNumber + "'";
                OleDbDataAdapter d = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                d.Fill(dt);
                withdrawGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding to customer withdraw to data gridview " + ex, "Error");
            }
            connection.sqlCon.Close();
        }

        private void withdrawGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = withdrawGridView.Rows[e.RowIndex];
                txtAmountWithdraw.Text = row.Cells[0].Value.ToString();
                txtParticulars.Text = row.Cells[1].Value.ToString();
                txtNewBalance.Text = row.Cells[2].Value.ToString();
                txtDate.Text = row.Cells[3].Value.ToString();
            }
        }

        private void withdrawGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = withdrawGridView.Rows[e.RowIndex];
                txtAmountWithdraw.Text = row.Cells[0].Value.ToString();
                txtParticulars.Text = row.Cells[1].Value.ToString();
                txtNewBalance.Text = row.Cells[2].Value.ToString();
                txtDate.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
