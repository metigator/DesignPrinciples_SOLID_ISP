namespace SOLID.ISP.Before
{
    interface IEntitlement
    { 
        decimal CalculatePension();
        decimal CalculateHealthInsurance();
        decimal CalculateRentalSubsidy();
        decimal CalculateBonuses();
        decimal CalculateTransportationReimbursement();

    }
}
