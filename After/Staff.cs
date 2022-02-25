using System;
namespace SOLID.ISP.After
{
    class Staff : Employee, IHealthInsuranceEntitlement, IPensionEntitlement, IRentalSubsidyEntitlement, IBonusesEntitlement
    {
        public decimal CalculateBonuses() => Salary * 0.05m;

        public decimal CalculateHealthInsurance() => 300m;

        public decimal CalculatePension() => .025m * Salary;

        public decimal CalculateRentalSubsidy() => 150;

        protected override decimal CalculateNetSalary()
        {
            return Salary 
                   + CalculateBonuses()
                   + CalculateHealthInsurance()
                   - CalculatePension()
                   + CalculateRentalSubsidy();
                   
        }

        public override string PrintSalarySlip()
        {
            return $"\n --- {nameof(Staff)} ---" +
                   $"\n  No.: {EmployeeNo}" +
                   $"\n  Name: {Name}" +
                   $"\n  Basic Salary: {Salary.ToString("C2")}" +
                   $"\n  Bonuses: {CalculateBonuses().ToString("C2")}" +
                   $"\n  Pension: {CalculatePension().ToString("C2")}" +
                   $"\n  Health Insurance: {CalculateHealthInsurance().ToString("C2")}" +
                   $"\n  Rental Subsidy: {CalculateRentalSubsidy().ToString("C2")}" +
                   $"\n  ----------------------------------------------" +
                   $"\n  NetSalary: {CalculateNetSalary().ToString("C2")}";
        }
        
    }
}
