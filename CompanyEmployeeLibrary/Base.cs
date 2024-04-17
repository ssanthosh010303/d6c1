/*
 * Author: Sakthi Santhosh
 * Created on: 16/04/2024
 */
namespace CompanyLibrary;

public interface ICompanyEmployee
{
    public void PrintEmployee();
    public double CalculateProvidentFund();
    public double CalculateGratuity();
    public string LeaveDetails();
}

public class CompanyEmployee
(
    uint id,
    string fullName,
    string department,
    string designation,
    double basicSalary,
    byte serviceYears,
    float providentFundCutPercentage
) : ICompanyEmployee
{
    protected uint id = id;
    protected string fullName = fullName, department = department, designation = designation;
    protected double basicSalary = basicSalary;
    protected byte serviceYears = serviceYears;
    protected float providentFundCutPercentage = providentFundCutPercentage;

    protected byte sickLeaveDaysPerMonth, privilegedLeaveDaysPerMonth, casualLeaveDaysPerMonth;

    public virtual void PrintEmployee()
    {
        Console.WriteLine("ID:            " + id);
        Console.WriteLine("Full name:     " + fullName);
        Console.WriteLine("Department:    " + department);
        Console.WriteLine("Designation:   " + designation);
        Console.WriteLine("Basic salary:  " + basicSalary);
        Console.WriteLine("Service years: " + serviceYears);
    }

    public virtual double CalculateProvidentFund()
    {
        return 0;
    }

    public virtual string LeaveDetails()
    {
        return
        (
            $"  Sick:       {sickLeaveDaysPerMonth}\n"
            + $"  Privileged: {privilegedLeaveDaysPerMonth}\n"
            + $"  Clinical:   {casualLeaveDaysPerMonth}"
        );
    }

    public virtual double CalculateGratuity()
    {
        return 0;
    }
}
