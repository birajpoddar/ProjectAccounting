using System;
namespace ProjectAccounting.Models;

public class Employee
{
	public Employee()
	{
	}

	// Unique EmployeeId of the employee
	public int EmployeeId { get; init; }
	// Full Name of the employee
	public string Name { get; set; }
	// Department Name of the Department where the Employee is working
	public string Department { get; set; }
	// Billing ProjectId for the employee
	public string ProjectId { get; set; }


}

