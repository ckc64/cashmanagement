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
    public partial class DepositTransaction : Form
    {
        public DepositTransaction()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllForms.depositForm.Show();
        }

        private void DepositTransaction_Load(object sender, EventArgs e)
        {
            connection.sqlCon.Open();
            try
            {

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection.sqlCon;

                command.CommandText = "SELECT amountdep AS AMOUNT_DEPOSITED, particular AS PARTICULAR, newbalance AS NEW_BALANCE, datetransact AS DATE_TRANSACT FROM customerdeposit WHERE accnum='"+Searching.AccNumber+"'";
                OleDbDataAdapter d = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                d.Fill(dt);
                depositGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding to customer deposit to data gridview " + ex, "Error");
            }
            connection.sqlCon.Close();
        }

        private void depositGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = depositGridView.Rows[e.RowIndex];
                txtAmoundDeposit.Text = row.Cells[0].Value.ToString();
                txtParticulars.Text = row.Cells[1].Value.ToString();
                txtNewBalance.Text = row.Cells[2].Value.ToString();
                txtDate.Text = row.Cells[3].Value.ToString();
            }
        }

        private void depositGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = depositGridView.Rows[e.RowIndex];
                txtAmoundDeposit.Text = row.Cells[0].Value.ToString();
                txtParticulars.Text = row.Cells[1].Value.ToString();
                txtNewBalance.Text = row.Cells[2].Value.ToString();
                txtDate.Text = row.Cells[3].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS PART IS UNDER DEVELOPMENT", "Error");
        }
    }
}
