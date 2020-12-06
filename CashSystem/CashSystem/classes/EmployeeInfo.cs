using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashSystem.classes
{
    public static class  CustomerInfo
    {
        //mandatory
        private static String lastName;
        private static String firstName;
        private static String middleName;
        private static String suffix;
        private static String dateOfBirth;
        private static String placeOfBirth;
        private static String presentAddress;
        private static String permanentAddress;
        private static String contactNum;
        private static String emailAddress;
        private static String nationality;
        private static String natureOfEmployment;
        private static String nameOfEmployer;
        private static String sourceOfFunds;
        private static String tinssgsisumidno;

        //client profiling
        private static String civilStatus;
        private static String gender;
        private static String typeOfID;
        private static String idNumber;
        private static String spouseName;
        private static String motherMaidenName;
        private static String employerBusinessAddr;
        private static String emergencyContactName;
        private static String emergencyContactNum;
        private static String primBeneficiary;
        private static String secBeneficiary;
        private static String jobTitlePosition;
        private static String purposeOfAccOpening;
        private static String monthlyBankStatement;
        private static String typesOfProductsAvailed;
        private static String prominentPosition;
        private static String spouseProminentPosition;

        private static int currentBalance;

        private static String accNumber;

        private static String isATM;
        private static String isPassbook;
        private static String isDollar;
        private static String isPeso;

        public static string LastName { get => lastName; set => lastName = value; }
        public static string FirstName { get => firstName; set => firstName = value; }
        public static string MiddleName { get => middleName; set => middleName = value; }
        public static string Suffix { get => suffix; set => suffix = value; }
        public static string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public static string PlaceOfBirth { get => placeOfBirth; set => placeOfBirth = value; }
        public static string PresentAddress { get => presentAddress; set => presentAddress = value; }
        public static string PermanentAddress { get => permanentAddress; set => permanentAddress = value; }
        public static string ContactNum { get => contactNum; set => contactNum = value; }
        public static string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public static string Nationality { get => nationality; set => nationality = value; }
        public static string NatureOfEmployment { get => natureOfEmployment; set => natureOfEmployment = value; }
        public static string NameOfEmployer { get => nameOfEmployer; set => nameOfEmployer = value; }
        public static string SourceOfFunds { get => sourceOfFunds; set => sourceOfFunds = value; }
        public static string Tinssgsisumidno { get => tinssgsisumidno; set => tinssgsisumidno = value; }
        public static string CivilStatus { get => civilStatus; set => civilStatus = value; }
        public static string Gender { get => gender; set => gender = value; }
        public static string TypeOfID { get => typeOfID; set => typeOfID = value; }
        public static string IdNumber { get => idNumber; set => idNumber = value; }
        public static string SpouseName { get => spouseName; set => spouseName = value; }
        public static string MotherMaidenName { get => motherMaidenName; set => motherMaidenName = value; }
        public static string EmployerBusinessAddr { get => employerBusinessAddr; set => employerBusinessAddr = value; }
        public static string EmergencyContactName { get => emergencyContactName; set => emergencyContactName = value; }
        public static string EmergencyContactNum { get => emergencyContactNum; set => emergencyContactNum = value; }
        public static string PrimBeneficiary { get => primBeneficiary; set => primBeneficiary = value; }
        public static string SecBeneficiary { get => secBeneficiary; set => secBeneficiary = value; }
        public static string JobTitlePosition { get => jobTitlePosition; set => jobTitlePosition = value; }
        public static string PurposeOfAccOpening { get => purposeOfAccOpening; set => purposeOfAccOpening = value; }
        public static string MonthlyBankStatement { get => monthlyBankStatement; set => monthlyBankStatement = value; }
        public static string TypesOfProductsAvailed { get => typesOfProductsAvailed; set => typesOfProductsAvailed = value; }
        public static string ProminentPosition { get => prominentPosition; set => prominentPosition = value; }
        public static string SpouseProminentPosition { get => spouseProminentPosition; set => spouseProminentPosition = value; }
        public static int CurrentBalance { get => currentBalance; set => currentBalance = value; }
        public static string AccNumber { get => accNumber; set => accNumber = value; }
        public static string IsATM { get => isATM; set => isATM = value; }
        public static string IsPassbook { get => isPassbook; set => isPassbook = value; }
        public static string IsDollar { get => isDollar; set => isDollar = value; }
        public static string IsPeso { get => isPeso; set => isPeso = value; }
    }
}
