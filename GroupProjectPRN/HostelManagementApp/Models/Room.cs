using System;
using System.Collections.Generic;

namespace HostelManagementApp.Models;

public partial class Room
{
    public int RoomId { get; set; }

    public int RoomNumber { get; set; }

    public string RoomType { get; set; } = null!;

    public bool Status { get; set; }

    public int HostelId { get; set; }

    public double RoomPrice { get; set; }

    public virtual ICollection<Bill> Bills { get; } = new List<Bill>();

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();

    public virtual Hostel Hostel { get; set; } = null!;

    public virtual ICollection<Service> Services { get; } = new List<Service>();
}
