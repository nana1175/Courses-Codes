using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_P
{
    class Employee
    {
        private string empFName;
        private string empLastName;
        private int noOfDepedents;
        private double noOfHours;

        public Employee()
        {

        }

        public Employee(string first, string last, int dep, double hours)
        {
            empFName = first;
            empLastName = last;
            noOfDepedents = dep;
            noOfHours = hours;
        }

        public string EmpFName
        {
            set { empFName = value; }
            get { return empFName; }
        }

        public string EmpLastName
        {
            get { return empLastName; }
            set { empLastName = value; }
        }

        public int NoOfDependends
        {
            set { noOfDepedents = value; }
            get { return noOfDepedents; }
        }

        public double NoOfHours
        {
            set { noOfHours = value; }
            get { return noOfHours; }
        }

        public double DetermineGross()
        {
            const double Rate = 150.00;
            return noOfHours * Rate;
        }

        public double DetermineAgencyFee()
        {
            const double AGENCY_CHARGE = 0.13;
            return DetermineGross() * AGENCY_CHARGE;
        }

        public double DetermineFedTax()
        {
            const double FED_TAX = 0.25;
            const double DEP_ALLOW = 0.0575;
            double gross;
            gross = DetermineGross();
            return (gross - (gross * (DEP_ALLOW * noOfDepedents))) *
                FED_TAX;
        }

        public double DetermineSS()
        {
            const double SSRATE = 0.0785;
            return DetermineGross() * SSRATE;
        }

        public double DetermineNet()
        {
            return DetermineGross() - DetermineSS() - DetermineFedTax() -
                DetermineAgencyFee();
        }

        public override string ToString()
        {
            return empFName + " " + empLastName +
                "\nTake Home Pay " + DetermineNet().ToString("C");
        }
    }

}
