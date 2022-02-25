using System;
namespace SOLID.ISP.Before
{
    class Consultant : Employee , IEntitlement
    {
        public decimal CalculateBonuses() => Salary * 0.05m;

        public decimal CalculateHealthInsurance() => 300m;

        public decimal CalculatePension() =>
            throw new NotSupportedException("Consultant Pension not supported");

        public decimal CalculateRentalSubsidy() => 
            throw new NotSupportedException("Consultant Rental Subsidy not supported");

        public decimal CalculateTransportationReimbursement() => 150;

        protected override decimal CalculateNetSalary()
        {
            return Salary
                   + CalculateBonuses()
                   + CalculateHealthInsurance() 
                   + CalculateTransportationReimbursement();

        }

        public override string PrintSalarySlip()
        {
            return $"\n --- {nameof(Consultant)} ---" +
                   $"\n  No.: {EmployeeNo}" +
                   $"\n  Name: {Name}" +
                   $"\n  Basic Salary: {Salary.ToString("C2")}" +
                   $"\n  Bonuses: {CalculateBonuses().ToString("C2")}" + 
                   $"\n  Health Insurance: {CalculateHealthInsurance().ToString("C2")}" +
                   $"\n  Transportation Reimbursement: {CalculateTransportationReimbursement().ToString("C2")}" +
                   $"\n  ----------------------------------------------" +
                   $"\n  NetSalary: {CalculateNetSalary().ToString("C2")}";
        }
    }
}
