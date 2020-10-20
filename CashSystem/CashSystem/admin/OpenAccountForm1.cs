﻿using CashSystem.classes;
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

            EmployeeInfo.LastName = txtLname.Text;
            EmployeeInfo.FirstName = txtFname.Text;
            EmployeeInfo.MiddleName = txtMname.Text;
            EmployeeInfo.Suffix = txtSuffix.Text;
            EmployeeInfo.DateOfBirth = cmbMonth.Text + "/" + cmbDay.Text + "/" + txtYear.Text;
            EmployeeInfo.PlaceOfBirth = txtPOfBirth.Text;
            EmployeeInfo.PresentAddress = txtPresentAddress.Text;
            EmployeeInfo.PermanentAddress = txtPermanentAddress.Text;
            EmployeeInfo.ContactNum = txtContactNum.Text;
            EmployeeInfo.EmailAddress = txtEmailAddr.Text;
            EmployeeInfo.Nationality = txtNationality.Text;
            EmployeeInfo.NatureOfEmployment = txtNatureOfEmployment.Text;
            EmployeeInfo.NameOfEmployer = txtNameOfEmployer.Text;
            EmployeeInfo.SourceOfFunds = txtSourceOfFunds.Text;
            EmployeeInfo.Tinssgsisumidno = txtTinIDNo.Text;
           
            this.Hide();
            AllForms.openAccountForm2.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
