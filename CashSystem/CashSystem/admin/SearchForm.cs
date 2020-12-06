using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashSystem.admin
{
    public partial class SearchForm : Form
    {
        String searchType;
        public SearchForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("THIS PART IS UNDER DEVELOPMENT", "Error");
            this.Hide();
            //AllForms.detailsAccountForm1.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                searchType = "Customer";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                searchType = "Employee";
            }
        }
    }
}
