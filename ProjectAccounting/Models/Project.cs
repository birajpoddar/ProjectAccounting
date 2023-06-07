using System;
namespace ProjectAccounting.Models;

public class Project
{
	public enum ProjectType
	{
		TNM,
		Milestone
	}

	public Project()
	{
	}

	public int ProjectId { get; init; }
	public string Name { get; set; }
	public ProjectType Type { get; set; }
	public double InvoiceAmount { get; private set; }
	public double BalanceDue { get; private set; }
	public bool IsCompleted { get; private set; } // 
	public bool IsProgress { get; private set; }
	public bool IsPaid { get; private set; }
	public DateTime PaymentDate { get; set; }

    /// <summary>
    /// Returns a list of Employees working on the project
    /// </summary>
    /// <returns>IEnumerable<Employee> or Empty IEnumerable, if no employees are working</returns>
    public IEnumerable<Employee> GetEmployees() {
		return null;
	}

	public void StartProject()
	{
		this.IsProgress = true;
	}

	public void CompleteProject()
	{
		this.IsProgress = false;
		this.IsCompleted = true;
	}


}

