/*
 * Author: Sakthi Santhosh
 * Created on: 16/04/2024
 *
 * Day-6 Challenge-1: Employee Benifit Management System with Gratuity Calculation
 */
using CompanyLibrary;

namespace Challenge1;

class Program
{
    static void Main()
    {
        ICompanyEmployee abcCompanyEmployeeHandle = new AbcCompanyEmployee(
            25674, "Sakthi Santhosh", "R&D", "GM", 12000, 12);
        ICompanyEmployee xyzCompanyEmployeeHandle = new XyzCompanyEmployee(
            12658, "Attack Helicopter", "Mechanical", "Engineer", 18000, 18);

        abcCompanyEmployeeHandle.PrintEmployee();
        xyzCompanyEmployeeHandle.PrintEmployee();

        Console.WriteLine(abcCompanyEmployeeHandle.LeaveDetails());
        Console.WriteLine(xyzCompanyEmployeeHandle.LeaveDetails());
    }
}
