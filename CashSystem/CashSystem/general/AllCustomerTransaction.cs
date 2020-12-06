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
    public partial class AllCustomerTransaction : Form
    {
        public AllCustomerTransaction()
        {
            InitializeComponent();
        }

        private void AllCustomerTransaction_Load(object sender, EventArgs e)
        {
            connection.sqlCon.Open();
            try
            {

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection.sqlCon;

                command.CommandText = "SELECT * FROM customerdeposit d,customerwithdraw w";
                OleDbDataAdapter d = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                d.Fill(dt);
                transactionGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding to customer deposit to data gridview " + ex, "Error");
            }
            connection.sqlCon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS PART IS UNDER DEVELOPMENT", "Error");
        }
    }
}
