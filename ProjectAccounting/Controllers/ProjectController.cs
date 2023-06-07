using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAccounting.Models;

namespace ProjectAccounting.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Project>> GetAllProjects()
    {
        return Ok(null);
    }

    [HttpPost]
    public ActionResult<IEnumerable<Project>> GetProjectsByClient(int clientId)
    {
        return Ok(null);
    }

    [HttpPost]
    public ActionResult<IEnumerable<Project>> GetCompletedProjectsByClient(int clientId)
    {
        return Ok(null);
    }


}
