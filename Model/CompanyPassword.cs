using System;
using System.Collections.Generic;

namespace psmgrtest.Model;

public partial class CompanyPassword
{
    public CompanyPassword()
    {
    }

    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual Company Company { get; set; } = null!;

    public CompanyPassword(int companyId, string login, string password)
    {
        CompanyId = companyId;
        Login = login;
        Password = password;
    }
}
