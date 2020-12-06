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

namespace CashSystem.admin
{
    public partial class OpenAccountForm2 : Form
    {

       
        public OpenAccountForm2()
        {
            InitializeComponent();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomerInfo.CivilStatus = cmbCivilStatus.Text;
            CustomerInfo.Gender = cmbGender.Text;
            CustomerInfo.MonthlyBankStatement = cmbMonthlyStatement.Text;
            CustomerInfo.TypeOfID = cmbIDType.Text;
            CustomerInfo.IdNumber = txtIDNumber.Text;
            CustomerInfo.SpouseName = txtSpouseName.Text;
            CustomerInfo.MotherMaidenName = txtMMaidenName.Text;
            CustomerInfo.EmployerBusinessAddr = txtEmployerAddr.Text;
            CustomerInfo.EmergencyContactName = txtEmergencyName.Text;
            CustomerInfo.EmergencyContactNum = txtEmergecyNumber.Text;
            CustomerInfo.PrimBeneficiary = txtPrimBeneficiary.Text;
            CustomerInfo.SecBeneficiary = txtSecBeneficiary.Text;
            CustomerInfo.JobTitlePosition = txtJobPos.Text;
            CustomerInfo.PurposeOfAccOpening = txtPurposeAccOpening.Text;
            CustomerInfo.TypesOfProductsAvailed = txtTypesOfProducts.Text;
            CustomerInfo.ProminentPosition = txtGovernmentOffice1.Text + "/" + txtPosition1.Text;
            CustomerInfo.SpouseProminentPosition = txtGovernmentOffice2.Text + "/" + txtPosition2.Text;


            if(
                CustomerInfo.CivilStatus == "" ||
                CustomerInfo.Gender == "" ||
                CustomerInfo.MonthlyBankStatement == "" ||
                CustomerInfo.TypeOfID == "" ||
                CustomerInfo.IdNumber == "" ||          
                CustomerInfo.MotherMaidenName == "" ||
                CustomerInfo.EmployerBusinessAddr == "" ||
                CustomerInfo.EmergencyContactName == "" ||
                CustomerInfo.EmergencyContactNum == "" ||
                CustomerInfo.PrimBeneficiary == "" ||
                CustomerInfo.SecBeneficiary == "" ||
                CustomerInfo.JobTitlePosition == "" ||
                CustomerInfo.PurposeOfAccOpening == "" ||
                CustomerInfo.TypesOfProductsAvailed == ""
            )
            {
                MessageBox.Show("Some of the fields are empty.\nPlease check the empty fields before to proceed.", "Error");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure all the fields are correct ?", "Message", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                  
                    this.Hide();
                    AllForms.openAccountForm3.Show();
                }
            }
            
            

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
            txtGovernmentOffice1.Enabled = false;
            txtGovernmentOffice2.Enabled = false;
            txtPosition1.Enabled = false;
            txtPosition2.Enabled = false;
            txtTypesOfProducts.Enabled = false;
            rbtnNo1.Checked = true;
            rbtnNo2.Checked = true;
        }

        private void chkSavingsDep_CheckedChanged(object sender, EventArgs e)
        {
         

            if (chkSavingsDep.Checked == true)
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

                txtTypesOfProducts.Text = txtTypesOfProducts.Text.Replace("Savings Deposit;", "");
            }
            if (chkOthers.Checked == true && chkSavingsDep.Checked == true)
            {
                chkOthers.Checked = false;
                txtTypesOfProducts.Text = txtTypesOfProducts.Text + "Savings Deposit;";
            }
        }

        private void rbtnPassbook_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnPassbook.Checked == true)
            {
                rbtnDOLLAR.Enabled = true;
                rbtnPESO.Enabled = true;

                CustomerInfo.IsPassbook = "True";

            }
            else
            {
                CustomerInfo.IsPassbook = "False";
            }
        }

        private void rbtnPESO_CheckedChanged(object sender, EventArgs e)
        {
           

            if(rbtnPESO.Checked == true)
            {
                CustomerInfo.IsPeso = "True";
            }
            else
            {
                CustomerInfo.IsPeso = "False";
            }
        }

        private void rbtnATM_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnATM.Checked == true)
            {
                rbtnDOLLAR.Enabled = true;
                rbtnPESO.Enabled = true;

                CustomerInfo.IsATM = "True";
            }
            else
            {
                CustomerInfo.IsATM = "False";
            }

        }

        private void chkCurrentDepAcc_CheckedChanged(object sender, EventArgs e)
        {
            String temp = txtTypesOfProducts.Text = txtTypesOfProducts.Text;
            if (chkCurrentDepAcc.Checked == true)
            {
                txtTypesOfProducts.Text = txtTypesOfProducts.Text + "Current Deposit Account;";
            }
            else
            {
                txtTypesOfProducts.Text = txtTypesOfProducts.Text.Replace("Current Deposit Account;", "");
            }

            if (chkCurrentDepAcc.Checked == true && chkOthers.Checked == true)
            {
                chkOthers.Checked = false;
                txtTypesOfProducts.Text = txtTypesOfProducts.Text + "Current Deposit Account;";
            }
        }

        private void chkCertifcateTimeDep_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCertifcateTimeDep.Checked == true)
            {
                txtTypesOfProducts.Text = txtTypesOfProducts.Text + "Certificate of Time Deposit;";
            }
            else
            {
                txtTypesOfProducts.Text = txtTypesOfProducts.Text.Replace("Certificate of Time Deposit;", "");
            }
            if (chkCertifcateTimeDep.Checked == true && chkOthers.Checked == true)
            {
                chkOthers.Checked = false;
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
                CustomerInfo.IsDollar = "True";
            }
            else
            {
                CustomerInfo.IsDollar = "False";
            }
        }

        private void rbtnYes1_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnYes1.Checked == true)
            {
                txtPosition1.Enabled = true;
                txtGovernmentOffice1.Enabled = true;
            }
            else
            {
                txtPosition1.Text = "";
                txtGovernmentOffice1.Text = "";
                txtPosition1.Enabled = false;
                txtGovernmentOffice1.Enabled = false;
            }
        }

        private void rbtnYes2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnYes2.Checked == true)
            {
                txtPosition2.Enabled = true;
                txtGovernmentOffice2.Enabled = true;
            }
            else
            {
                txtPosition2.Text = "";
                txtGovernmentOffice2.Text = "";
                txtPosition2.Enabled = false;
                txtGovernmentOffice2.Enabled = false;
            }
        }
    }
}
