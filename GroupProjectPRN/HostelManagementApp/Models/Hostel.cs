using System;
using System.Collections.Generic;

namespace HostelManagementApp.Models;

public partial class Hostel
{
    public int HostelId { get; set; }

    public string HostelName { get; set; } = null!;

    public int LessorId { get; set; }

    public int LocationId { get; set; }

    public virtual Lessor Lessor { get; set; } = null!;

    public virtual HostelLocation Location { get; set; } = null!;

    public virtual ICollection<Room> Rooms { get; } = new List<Room>();
}
