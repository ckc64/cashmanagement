using CashSystem.admin;
using CashSystem.customer;
using CashSystem.general;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashSystem
{
    static class AllForms
    {
        public static AdminDashboard adminDashBoard = new AdminDashboard();
        public static WithdrawForm withdrawForm = new WithdrawForm();
        public static frmLogin login = new frmLogin();
        public static EmployeeCreateAccount createAccountEmployee = new EmployeeCreateAccount();

        //OPEN ACCOUNT FORMS
        public static OpenAccountForm1 openAccountForm1 = new OpenAccountForm1();
        public static OpenAccountForm2 openAccountForm2 = new OpenAccountForm2();

        //Create new account
        public static AccountsForm accountsForm = new AccountsForm();

        //Accounts
        public static SearchForm searchForm = new SearchForm();

        //Transactions
        public static AccountTransaction accountTransaction = new AccountTransaction();
        public static WithdrawalTransaction withdrawalTransaction = new WithdrawalTransaction();
        public static DepositTransaction depositTransaction = new DepositTransaction();
        public static AllTransactions allTransactions = new AllTransactions();

        //Detail Account
        public static DetailsAccountForm1 detailsAccountForm1 = new DetailsAccountForm1();
        public static DetailsAccountForm2 detailsAccountForm2 = new DetailsAccountForm2();

        //Customer
        public static CustomerDeposit customerDeposit = new CustomerDeposit();
        public static CustomerHome customerHome = new CustomerHome();
        public static CustomerWithdraw customerWithdraw = new CustomerWithdraw();

        public static CustomerBoard customerBoard = new CustomerBoard();

    }
}
