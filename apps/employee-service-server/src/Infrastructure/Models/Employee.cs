using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EmployeeService.Core.Enums;

namespace EmployeeService.Infrastructure.Models;

[Table("Employees")]
public class EmployeeDbModel
{
    [StringLength(1000)]
    public string? City { get; set; }

    [StringLength(1000)]
    public string? Country { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? Designation { get; set; }

    public GenderEnum? Gender { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? Name { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
