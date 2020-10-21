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
    public partial class OpenAccountForm2 : Form
    {

        String currency = "";
        String type = "";
        public OpenAccountForm2()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EmployeeInfo.CivilStatus = cmbCivilStatus.Text;
            EmployeeInfo.Gender = cmbGender.Text;
            EmployeeInfo.MonthlyBankStatement = cmbMonthlyStatement.Text;
            EmployeeInfo.TypeOfID = cmbIDType.Text;
            EmployeeInfo.IdNumber = txtIDNumber.Text;
            EmployeeInfo.SpouseName = txtSpouseName.Text;
            EmployeeInfo.MotherMaidenName = txtMMaidenName.Text;
            EmployeeInfo.EmployerBusinessAddr = txtEmployerAddr.Text;
            EmployeeInfo.EmergencyContactName = txtEmergencyName.Text;
            EmployeeInfo.EmergencyContactNum = txtEmergecyNumber.Text;
            EmployeeInfo.PrimBeneficiary = txtPrimBeneficiary.Text;
            EmployeeInfo.SecBeneficiary = txtSecBeneficiary.Text;
            EmployeeInfo.JobTitlePosition = txtJobPos.Text;
            EmployeeInfo.PurposeOfAccOpening = txtPurposeAccOpening.Text;
            EmployeeInfo.TypesOfProductsAvailed = txtTypesOfProducts.Text;
            EmployeeInfo.ProminentPosition = txtGovernmentOffice1.Text + "/" + txtPosition1.Text;
            EmployeeInfo.SpouseProminentPosition = txtGovernmentOffice2.Text + "/" + txtPosition2.Text;

            this.Close();
            AllForms.openAccountForm3.Show();

        }

        private void txtTypesOfProducts_TextChanged(object sender, EventArgs e)
        {
            ///if(ch)
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpenAccountForm2_Load(object sender, EventArgs e)
        {
            rbtnATM.Enabled = false;
            rbtnDOLLAR.Enabled = false;
            rbtnPassbook.Enabled = false;
            rbtnPESO.Enabled = false;

            txtTypesOfProducts.Enabled = false;
        }

        private void chkSavingsDep_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSavingsDep.Checked == true)
            {
                rbtnPassbook.Enabled = true;
                rbtnATM.Enabled = true;

                if (chkSavingsDep.Checked == true)
                {
                    txtTypesOfProducts.Text = txtTypesOfProducts.Text + "Savings Deposit;";
                }
            }
            else
            {
                rbtnATM.Enabled = false;
                rbtnDOLLAR.Enabled = false;
                rbtnPassbook.Enabled = false;
                rbtnPESO.Enabled = false;

                rbtnATM.Checked = false;
                rbtnPassbook.Checked = false;
                rbtnDOLLAR.Checked = false;
                rbtnPESO.Checked = false;
            }
        }

        private void rbtnPassbook_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnPassbook.Checked == true)
            {
                rbtnDOLLAR.Enabled = true;
                rbtnPESO.Enabled = true;

                EmployeeInfo.IsPassbook = "True";

            }
            else
            {
                EmployeeInfo.IsPassbook = "False";
            }
        }

        private void rbtnPESO_CheckedChanged(object sender, EventArgs e)
        {
           

            if(rbtnPESO.Checked == true)
            {
                EmployeeInfo.IsPeso = "True";
            }
            else
            {
                EmployeeInfo.IsPeso = "False";
            }
        }

        private void rbtnATM_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnATM.Checked == true)
            {
                rbtnDOLLAR.Enabled = true;
                rbtnPESO.Enabled = true;

                EmployeeInfo.IsATM = "True";
            }
            else
            {
                EmployeeInfo.IsATM = "False";
            }

        }

        private void chkCurrentDepAcc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCurrentDepAcc.Checked == true)
            {
                txtTypesOfProducts.Text = txtTypesOfProducts.Text + "Current Deposit Account;";
            }
        }

        private void chkCertifcateTimeDep_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCertifcateTimeDep.Checked == true)
            {
                txtTypesOfProducts.Text = txtTypesOfProducts.Text + "Certificate of Time Deposit;";
            }
        }

        private void chkOthers_CheckedChanged(object sender, EventArgs e)
        {
            if(chkOthers.Checked == true)
            {
                txtTypesOfProducts.Enabled = true;
                txtTypesOfProducts.Text = "";

                chkSavingsDep.Checked = false;
                chkCurrentDepAcc.Checked = false;
                chkCertifcateTimeDep.Checked = false;
            }
            else
            {
                txtTypesOfProducts.Enabled = false;
                txtTypesOfProducts.Text = "";
            }
        }

        private void rbtnDOLLAR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDOLLAR.Checked == true)
            {
                EmployeeInfo.IsDollar = "True";
            }
            else
            {
                EmployeeInfo.IsDollar = "False";
            }
        }
    }
}
