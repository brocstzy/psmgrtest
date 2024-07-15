using System;
using System.Collections.Generic;

namespace psmgrtest.Model;

public partial class Company
{
    public Company()
    {
    }

    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Image { get; set; }

    public virtual ICollection<CompanyPassword> CompanyPasswords { get; set; } = new List<CompanyPassword>();

    public Company(string name)
    {
        Name = name;
    }
}
