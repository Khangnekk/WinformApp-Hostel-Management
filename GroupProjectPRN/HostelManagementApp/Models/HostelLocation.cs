using System;
using System.Collections.Generic;

namespace HostelManagementApp.Models;

public partial class HostelLocation
{
    public int LocationId { get; set; }

    public string LocationDetail { get; set; } = null!;

    public virtual ICollection<Hostel> Hostels { get; } = new List<Hostel>();
}
