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

namespace CashSystem.admin
{
    public partial class OpenAccountForm1 : Form
    {
        public OpenAccountForm1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {

            CustomerInfo.LastName = txtLname.Text;
            CustomerInfo.FirstName = txtFname.Text;
            CustomerInfo.MiddleName = txtMname.Text;
            CustomerInfo.Suffix = txtSuffix.Text;
            CustomerInfo.DateOfBirth = cmbMonth.Text + "/" + cmbDay.Text + "/" + txtYear.Text;
            CustomerInfo.PlaceOfBirth = txtPOfBirth.Text;
            CustomerInfo.PresentAddress = txtPresentAddress.Text;
            CustomerInfo.PermanentAddress = txtPermanentAddress.Text;
            CustomerInfo.ContactNum = txtContactNum.Text;
            CustomerInfo.EmailAddress = txtEmailAddr.Text;
            CustomerInfo.Nationality = txtNationality.Text;
            CustomerInfo.NatureOfEmployment = txtNatureOfEmployment.Text;
            CustomerInfo.NameOfEmployer = txtNameOfEmployer.Text;
            CustomerInfo.SourceOfFunds = txtSourceOfFunds.Text;
            CustomerInfo.Tinssgsisumidno = txtTinIDNo.Text;
           
          

            if (CustomerInfo.LastName == "" ||
            CustomerInfo.FirstName == "" ||
            CustomerInfo.MiddleName == "" ||
           
            CustomerInfo.DateOfBirth == "" ||
            CustomerInfo.PlaceOfBirth == "" ||
            CustomerInfo.PresentAddress == "" ||
            CustomerInfo.PermanentAddress == "" ||
            CustomerInfo.ContactNum == "" ||
            CustomerInfo.EmailAddress == "" ||
            CustomerInfo.Nationality == "" ||
            CustomerInfo.NatureOfEmployment == "" ||
            CustomerInfo.NameOfEmployer == "" ||
            CustomerInfo.SourceOfFunds == "" ||
            CustomerInfo.Tinssgsisumidno == "")
            {
                MessageBox.Show("Some of the fields are empty.\nPlease check the empty fields before to proceed.", "Error");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure all the fields are correct ?", "Message", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Hide();
                    AllForms.openAccountForm2.Show();
                }
               
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel ?", "Message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                AllForms.adminDashBoard.Show();
            }
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
