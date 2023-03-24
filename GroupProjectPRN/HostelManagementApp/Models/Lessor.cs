using System;
using System.Collections.Generic;

namespace HostelManagementApp.Models;

public partial class Lessor
{
    public int LessorId { get; set; }

    public string LessorName { get; set; } = null!;

    public DateTime LessorDob { get; set; }

    public string Cccd { get; set; } = null!;

    public int LessorGender { get; set; }

    public string Username { get; set; } = null!;

    public virtual ICollection<Hostel> Hostels { get; } = new List<Hostel>();

    public virtual Account UsernameNavigation { get; set; } = null!;
}
