using System;
using System.Collections.Generic;

namespace HostelManagementApp.Models;

public partial class Service
{
    public int ServiceId { get; set; }

    public string ServiceName { get; set; } = null!;

    public double ServicePrice { get; set; }

    public virtual ICollection<Room> Rooms { get; } = new List<Room>();
}
