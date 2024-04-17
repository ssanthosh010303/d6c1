/*
 * Author: Sakthi Santhosh
 * Created on: 16/04/2024
 */
namespace CompanyLibrary;

public class AbcCompanyEmployee : CompanyEmployee
{
    public AbcCompanyEmployee
    (
        uint id,
        string fullName,
        string department,
        string designation,
        double basicSalary,
        byte serviceYears,
        float providentFundCutPercentage = 3.67f
    ) : base
    (
        id,
        fullName,
        department,
        designation,
        basicSalary,
        serviceYears,
        providentFundCutPercentage
    )
    {
        sickLeaveDaysPerMonth = 12;
        privilegedLeaveDaysPerMonth = 10;
        casualLeaveDaysPerMonth = 1;
    }

    public override void PrintEmployee()
    {
        Console.WriteLine("\nEmployee Details (ABC)");
        base.PrintEmployee();
    }

    public override double CalculateProvidentFund()
    {
        return basicSalary * providentFundCutPercentage;
    }

    public override string LeaveDetails()
    {
        return $"\nLeave Details (ABC: {fullName})\n" + base.LeaveDetails();
    }

    public override double CalculateGratuity()
    {
        if (serviceYears > 20) return basicSalary * (0.03);
        if (serviceYears > 10) return basicSalary * (0.02);
        if (serviceYears > 05) return basicSalary;
        return 0;
    }
}

public class XyzCompanyEmployee : CompanyEmployee
{
    public XyzCompanyEmployee
    (
        uint id,
        string fullName,
        string department,
        string designation,
        double basicSalary,
        byte serviceYears,
        float providentFundCutPercentage = 0.12f
    ) : base
    (
        id,
        fullName,
        department,
        designation,
        basicSalary,
        serviceYears,
        providentFundCutPercentage
    )
    {
        sickLeaveDaysPerMonth = 5;
        privilegedLeaveDaysPerMonth = 5;
        casualLeaveDaysPerMonth = 2;
    }

    public override void PrintEmployee()
    {
        Console.WriteLine("\nEmployee Details (XYZ)");
        base.PrintEmployee();
    }

    public override double CalculateProvidentFund()
    {
        return basicSalary * providentFundCutPercentage;
    }

    public override string LeaveDetails()
    {
        return $"\nLeave Details (XYZ: {fullName})\n" + base.LeaveDetails();
    }

    public override double CalculateGratuity()
    {
        return base.CalculateGratuity();
    }
}
