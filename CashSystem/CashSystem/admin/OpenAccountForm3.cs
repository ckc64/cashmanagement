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
    public partial class OpenAccountForm3 : Form
    {
        public OpenAccountForm3()
        {
      
            InitializeComponent();
        }

        private void btnViewAllTransact_Click(object sender, EventArgs e)
        {
            EmployeeInfo.AccNumber = txtAccNum.Text;
            txtName.Text = EmployeeInfo.LastName + ", " + EmployeeInfo.FirstName + ", " + EmployeeInfo.MiddleName + ", " + EmployeeInfo.Suffix;
            EmployeeInfo.CurrentBalance = Int32.Parse(txtInitialDeposit.Text);

            String saveToClientProf = "INSERT INTO clientproftbl " +
                "(accnum,civilstatus,gender,typeofid,idnumber,spousename,mmname,empbusinessaddr,emergencyname,emergencynum," +
                "primbeneficiary,secbeneficiary,jobtitleposition,purposeofaccopening,mbankstatement,topavailed,govpromposition,spousegovpromposition,datejoin)" +
                "VALUES ('"+EmployeeInfo.AccNumber+"','"+EmployeeInfo.CivilStatus+"','"+EmployeeInfo.Gender+"'" +
                ",'"+EmployeeInfo.TypeOfID+"','"+EmployeeInfo.IdNumber+"','"+EmployeeInfo.SpouseName+"'" +
                ",'"+EmployeeInfo.MotherMaidenName+"','"+EmployeeInfo.EmployerBusinessAddr+"','"+EmployeeInfo.EmergencyContactName+"'" +
                ",'"+EmployeeInfo.EmergencyContactNum+"','"+EmployeeInfo.PrimBeneficiary+"','"+EmployeeInfo.SecBeneficiary+"'" +
                ",'"+EmployeeInfo.JobTitlePosition+"','"+EmployeeInfo.PurposeOfAccOpening+"','"+EmployeeInfo.MonthlyBankStatement+"'" +
                ",'"+EmployeeInfo.TypesOfProductsAvailed+"','"+EmployeeInfo.ProminentPosition+"','"+EmployeeInfo.SpouseProminentPosition+"','"+DateTime.Now+"')";
            
            String saveToMandatory = "INSERT INTO mandatoryinfotbl " +
                    "(accnum,lname,fname,mname,suffix,dateofbirth,placeofbirth,presentaddress,permanentaddress," +
                    "contactnumber,emailaddress,nationality,natureofemployment,nameofemployer,sourceoffunds,tinsssgsisumidno)" +
                    "VALUES ('" + EmployeeInfo.AccNumber + "','" + EmployeeInfo.LastName + "'" +
                    ",'" + EmployeeInfo.FirstName + "','" + EmployeeInfo.MiddleName + "','" + EmployeeInfo.Suffix + "'" +
                    ",'" + EmployeeInfo.DateOfBirth + "','" + EmployeeInfo.PlaceOfBirth + "','" + EmployeeInfo.PresentAddress + "'" +
                    ",'" + EmployeeInfo.PermanentAddress + "','" + EmployeeInfo.ContactNum + "','" + EmployeeInfo.EmailAddress + "'" +
                    ",'" + EmployeeInfo.Nationality + "','" + EmployeeInfo.NatureOfEmployment + "','" + EmployeeInfo.NameOfEmployer + "'" +
                    ",'" + EmployeeInfo.SourceOfFunds + "','" + EmployeeInfo.Tinssgsisumidno + "')";

            String particulars = "Initial Deposit of " + EmployeeInfo.CurrentBalance;
            String saveToCustomerDep = "INSERT INTO customerdeposit " +
                "(accnum,amountdep,particular) " +
                "VALUES ('"+EmployeeInfo.AccNumber+"','"+EmployeeInfo.CurrentBalance+"','"+particulars+"')";

            String allQueries = string.Join(";", saveToMandatory, saveToClientProf, saveToCustomerDep);
            try
            {
                connection.sqlCon.Open();
                connection.command.Connection = connection.sqlCon;
                ///INSERT TO MANDATORY TABLE
                connection.command.CommandText = allQueries;

                connection.command.ExecuteNonQuery();

                connection.sqlCon.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Save Customer" + ex);
            }


        }

        private void OpenAccountForm3_Load(object sender, EventArgs e)
        {
            Random generator = new Random();
            int r = generator.Next(0, 999999);
            string accNumber = String.Format("32{0}", r.ToString("D6"));
            txtAccNum.Text = accNumber;
        }
    }
}
