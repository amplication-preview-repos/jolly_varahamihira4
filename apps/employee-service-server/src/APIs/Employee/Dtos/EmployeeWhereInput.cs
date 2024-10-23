using EmployeeService.Core.Enums;

namespace EmployeeService.APIs.Dtos;

public class EmployeeWhereInput
{
    public string? City { get; set; }

    public string? Country { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? Designation { get; set; }

    public GenderEnum? Gender { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
