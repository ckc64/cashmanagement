using CashSystem.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashSystem.general
{
    public partial class SearchAccountTransaction : Form
    {
        public SearchAccountTransaction()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {
            /*if (txtName.Text == "" || txtName.Text == null)
            {
                btnViewDeposit.Enabled = false;
                btnViewWithdrawal.Enabled = false;
                btnViewDebit.Enabled = false;
                btnViewCredited.Enabled = false;
                btnViewAllTransact.Enabled = false;
            }
            else
            {
                btnViewDeposit.Enabled = true;
                btnViewWithdrawal.Enabled = true;
                btnViewDebit.Enabled = true;
                btnViewCredited.Enabled = true;
                btnViewAllTransact.Enabled = true;
            }*/
        }

        private void AccountTransaction_Load(object sender, EventArgs e)
        {
           /* if (txtName.Text == "")
            {
                btnViewDeposit.Enabled = false;
                btnViewWithdrawal.Enabled = false;
                btnViewDebit.Enabled = false;
                btnViewCredited.Enabled = false;
                btnViewAllTransact.Enabled = false;
            }
            else
            {
                btnViewDeposit.Enabled = true;
                btnViewWithdrawal.Enabled = true;
                btnViewDebit.Enabled = true;
                btnViewCredited.Enabled = true;
                btnViewAllTransact.Enabled = true;
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Searching.AccNumber = txtSearchAccNumber.Text;

            this.Hide();
            CustomerBoardAccountTransaction cus = new CustomerBoardAccountTransaction();
            cus.Show();
            txtSearchAccNumber.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnViewWithdrawal_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllForms.withdrawalTransaction.Show();
        }

        private void btnViewDeposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllForms.depositTransaction.Show();
        }

        private void btnViewAllTransact_Click(object sender, EventArgs e)
        {
            AllForms.allTransactions.Show();
        }
    }
}
