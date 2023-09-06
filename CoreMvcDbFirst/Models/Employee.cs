using System;
using System.Collections.Generic;

namespace CoreMvcDbFirst.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public string Email { get; set; } = null!;

    public double Salary { get; set; }

    public string Remark { get; set; } = null!;
}
