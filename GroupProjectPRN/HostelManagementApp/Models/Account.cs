using System;
using System.Collections.Generic;

namespace HostelManagementApp.Models;

public partial class Account
{
    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Lessor> Lessors { get; } = new List<Lessor>();
}
