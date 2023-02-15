using Microsoft.AspNetCore.Mvc;
using SmapleCodeFirst.Entities;
using SmapleCodeFirst.Services;

namespace SmapleCodeFirst.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class EmployeeController : ControllerBase
{

    private IEmployee _service;

    public EmployeeController(IEmployee service)
    {
        _service = service;

    }
    [HttpPost(Name = "GetWeatherForecast")]
    public async Task<IActionResult> Add(Employees data)
    {
        return Ok(_service.AddEmployes(data));
    }
}
