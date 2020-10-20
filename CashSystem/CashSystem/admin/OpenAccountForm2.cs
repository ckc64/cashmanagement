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

        }
    }
}
