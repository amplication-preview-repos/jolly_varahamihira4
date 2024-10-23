using EmployeeService.APIs;
using EmployeeService.APIs.Common;
using EmployeeService.APIs.Dtos;
using EmployeeService.APIs.Errors;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeService.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class EmployeesControllerBase : ControllerBase
{
    protected readonly IEmployeesService _service;

    public EmployeesControllerBase(IEmployeesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Employee
    /// </summary>
    [HttpPost()]
    public async Task<ActionResult<Employee>> CreateEmployee(EmployeeCreateInput input)
    {
        var employee = await _service.CreateEmployee(input);

        return CreatedAtAction(nameof(Employee), new { id = employee.Id }, employee);
    }

    /// <summary>
    /// Delete one Employee
    /// </summary>
    [HttpDelete("{Id}")]
    public async Task<ActionResult> DeleteEmployee([FromRoute()] EmployeeWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteEmployee(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Employees
    /// </summary>
    [HttpGet()]
    public async Task<ActionResult<List<Employee>>> Employees(
        [FromQuery()] EmployeeFindManyArgs filter
    )
    {
        return Ok(await _service.Employees(filter));
    }

    /// <summary>
    /// Meta data about Employee records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> EmployeesMeta(
        [FromQuery()] EmployeeFindManyArgs filter
    )
    {
        return Ok(await _service.EmployeesMeta(filter));
    }

    /// <summary>
    /// Get one Employee
    /// </summary>
    [HttpGet("{Id}")]
    public async Task<ActionResult<Employee>> Employee(
        [FromRoute()] EmployeeWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.Employee(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Employee
    /// </summary>
    [HttpPatch("{Id}")]
    public async Task<ActionResult> UpdateEmployee(
        [FromRoute()] EmployeeWhereUniqueInput uniqueId,
        [FromQuery()] EmployeeUpdateInput employeeUpdateDto
    )
    {
        try
        {
            await _service.UpdateEmployee(uniqueId, employeeUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
