using System;
using System.Collections.Generic;

namespace Example.DL;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string EmployeeName { get; set; } = null!;

    public string? EmployeeAddress { get; set; }

    public string EmployeeEmail { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime EmployeeJoiningDate { get; set; }

    public string EmployeeExperience { get; set; } = null!;

    public int Technology { get; set; }

    public int Role { get; set; }

    public int? Department { get; set; }

    public string? EmployeeStatus { get; set; }

    public virtual ICollection<EmployeeMapping> EmployeeMappingEmployees { get; set; } = new List<EmployeeMapping>();

    public virtual ICollection<EmployeeMapping> EmployeeMappingManagers { get; set; } = new List<EmployeeMapping>();

    public virtual ICollection<ProjectMember> ProjectMembers { get; set; } = new List<ProjectMember>();
}
