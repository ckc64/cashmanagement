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
    public partial class OpenAccountForm3 : Form
    {
        public OpenAccountForm3()
        {
      
            InitializeComponent();
        }

        private void btnViewAllTransact_Click(object sender, EventArgs e)
        {

            if(txtInitialDeposit.Text == "")
            {
                MessageBox.Show("Initial Deposit must not be empty.","ERROR");
            }
            else
            {
                CustomerInfo.AccNumber = txtAccNum.Text;

                CustomerInfo.CurrentBalance = Int32.Parse(txtInitialDeposit.Text);

                ///INSERT FUNCTION
                // String allQueries = string.Join(";", saveToMandatory, saveToClientProf, saveToCustomerDep,saveToCustomerBalance);
                connection.sqlCon.Open();
                ///Mandatory table insert
                try
                {


                    String saveToMandatory = "INSERT INTO mandatoryinfotbl " +
                            "(accnum,lname,fname,mname,suffix,dateofbirth,placeofbirth,presentaddress,permanentaddress," +
                            "contactnumber,emailaddress,nationality,natureofemployment,nameofemployer,sourceoffunds,tinsssgsisumidno)" +
                            "VALUES ('" + CustomerInfo.AccNumber + "','" + CustomerInfo.LastName + "'" +
                            ",'" + CustomerInfo.FirstName + "','" + CustomerInfo.MiddleName + "','" + CustomerInfo.Suffix + "'" +
                            ",'" + CustomerInfo.DateOfBirth + "','" + CustomerInfo.PlaceOfBirth + "','" + CustomerInfo.PresentAddress + "'" +
                            ",'" + CustomerInfo.PermanentAddress + "','" + CustomerInfo.ContactNum + "','" + CustomerInfo.EmailAddress + "'" +
                            ",'" + CustomerInfo.Nationality + "','" + CustomerInfo.NatureOfEmployment + "','" + CustomerInfo.NameOfEmployer + "'" +
                            ",'" + CustomerInfo.SourceOfFunds + "','" + CustomerInfo.Tinssgsisumidno + "')";



                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection.sqlCon;

                    command.CommandText = saveToMandatory;

                    command.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Save Customer Mandatory" + ex);
                }


                ///Client Profile table insert
                try
                {

                    String saveToClientProf = "INSERT INTO clientproftbl " +
                           "(accnum,civilstatus,gender,typeofid,idnumber,spousename,mmname,empbusinessaddr,emergencyname,emergencynum," +
                           "primbeneficiary,secbeneficiary,jobtitleposition,purposeofaccopening,mbankstatement,topavailed,isatm,ispassbook,ispeso,isdollar,govpromposition,spousegovpromposition,datejoin)" +
                           "VALUES ('" + CustomerInfo.AccNumber + "','" + CustomerInfo.CivilStatus + "','" + CustomerInfo.Gender + "'" +
                           ",'" + CustomerInfo.TypeOfID + "','" + CustomerInfo.IdNumber + "','" + CustomerInfo.SpouseName + "'" +
                           ",'" + CustomerInfo.MotherMaidenName + "','" + CustomerInfo.EmployerBusinessAddr + "','" + CustomerInfo.EmergencyContactName + "'" +
                           ",'" + CustomerInfo.EmergencyContactNum + "','" + CustomerInfo.PrimBeneficiary + "','" + CustomerInfo.SecBeneficiary + "'" +
                           ",'" + CustomerInfo.JobTitlePosition + "','" + CustomerInfo.PurposeOfAccOpening + "','" + CustomerInfo.MonthlyBankStatement + "'" +
                           ",'" + CustomerInfo.TypesOfProductsAvailed + "','" + CustomerInfo.IsATM + "','" + CustomerInfo.IsPassbook + "','" + CustomerInfo.IsPeso + "','" + CustomerInfo.IsDollar + "'" +
                           ",'" + CustomerInfo.ProminentPosition + "','" + CustomerInfo.SpouseProminentPosition + "','" + DateTime.Now + "')";



                    OleDbCommand command1 = new OleDbCommand();
                    command1.Connection = connection.sqlCon;

                    command1.CommandText = saveToClientProf;

                    command1.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Save Customer Client Profile" + ex);
                }

                ///SaveTocustomer deposit table insert
                try
                {

                    String particulars = "Initial Deposit of " + CustomerInfo.CurrentBalance;

                    String saveToCustomerDep = "INSERT INTO customerdeposit " +
                        "(accnum,amountdep,particular,newbalance,datetransact) " +
                        "VALUES ('" + CustomerInfo.AccNumber + "','" + CustomerInfo.CurrentBalance + "','" + particulars + "','" + CustomerInfo.CurrentBalance + "','" + DateTime.Now + "')";


                    OleDbCommand command2 = new OleDbCommand();
                    command2.Connection = connection.sqlCon;

                    command2.CommandText = saveToCustomerDep;

                    command2.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Save Customer Deposit" + ex);
                }

                ///SaveTocustomer deposit table insert
                try
                {
                    String saveToCustomerBalance = "INSERT INTO customerbalance (accnum,currentbalance,asof) " +
                                  "VALUES ('" + CustomerInfo.AccNumber + "','" + CustomerInfo.CurrentBalance + "','" + DateTime.Now + "')";


                    OleDbCommand command3 = new OleDbCommand();
                    command3.Connection = connection.sqlCon;

                    command3.CommandText = saveToCustomerBalance;

                    command3.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Save To Customer Balance" + ex);
                }


                MessageBox.Show("THE CUSTOMER DETAILS IS ALREADY SAVED", "SUCCESS");
                this.Hide();
                AllForms.adminDashBoard.Show();
                connection.sqlCon.Close();


            }

        }
          

          
           
          

        private void OpenAccountForm3_Load(object sender, EventArgs e)
        {
            txtName.Text = CustomerInfo.LastName.ToUpper() + ", " + CustomerInfo.FirstName.ToUpper() + ", " + CustomerInfo.MiddleName.ToUpper() + " " + CustomerInfo.Suffix.ToUpper();
            Random generator = new Random();
            char c1 = (char)generator.Next('A', 'Z');
            char c2 = (char)generator.Next('A', 'Z');
            int r = generator.Next(0, 999999);
            string accNumber = String.Format("UMTC{1}{0}{2}", r.ToString("D10"),c1,c2);
            txtAccNum.Text = accNumber;
        }

        private void txtInitialDeposit_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
