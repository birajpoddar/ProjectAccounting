using System;
namespace ProjectAccounting.Models;

public class Client
{
	public Client()
	{
	}

	// Unique ClientId for the client
	public int ClientId { get; init; }
	// Name of the client
	public string Name { get; set; }

    /// <summary>
    /// Retuns the Project Summary for all the projects undergoing for the client
    /// </summary>
    /// <returns>IEnumberable<Project> with all projects for the client or an Empty IEnumberable in case no Projects are available for the client</returns>
    public IEnumerable<Project> GetProjects()
	{
		return null;
	}

	/// <summary>
	/// Retuns the Project Summary for the project
	/// </summary>
	/// <param name="projectId">The ProjectId for the project whose summary is requested</param>
	/// <returns>Returns a Project object or Null in case no Project is found for the supplied ProjectId</returns>
    public Project GetProject(int projectId)
    {
		return null;
    }

	/// <summary>
	/// Returns all active Projects for the client
	/// </summary>
	/// <returns>IEnumberable<Project> with all projects in IsProgress status for the client or an Empty IEnumberable in case no IsProgress Projects are available for the client</returns>
    public IEnumerable<Project> GetActiveProjects()
    {
		return null;
    }

	/// <summary>
	/// Will return the balance due for all completed projects
	/// </summary>
	/// <returns>The total amount due for all completed projects for the Client (in USD) or ZERO(0) in case no pending payment is available</returns>
    public double GetTotalBalanceDue()
	{
		return 0;
	}
}

