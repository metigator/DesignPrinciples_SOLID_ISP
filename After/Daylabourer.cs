using System;
namespace SOLID.ISP.After
{
    class Daylabourer : Employee , IHealthInsuranceEntitlement, ITransportationReimbursementEntitlement
    {
        public decimal CalculateHealthInsurance() => 300m;

        public decimal CalculateTransportationReimbursement() => 150;

        protected override decimal CalculateNetSalary()
        {
            return Salary 
                + CalculateHealthInsurance()
                + CalculateTransportationReimbursement();

        }

        public override string PrintSalarySlip()
        {
            return $"\n --- {nameof(Daylabourer)} ---" +
                   $"\n  No.: {EmployeeNo}" +
                   $"\n  Name: {Name}" +
                   $"\n  Basic Salary: {Salary.ToString("C2")}" + 
                   $"\n  Health Insurance: {CalculateHealthInsurance().ToString("C2")}" +
                   $"\n  Transportation Reimbursement: {CalculateTransportationReimbursement().ToString("C2")}" +
                   $"\n  ----------------------------------------------" +
                   $"\n  NetSalary: {CalculateNetSalary().ToString("C2")}";
        }
    }
}
