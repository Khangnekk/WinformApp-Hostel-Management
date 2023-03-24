using System;
using System.Collections.Generic;

namespace HostelManagementApp.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string PlaceOfOrigin { get; set; } = null!;

    public string Cccd { get; set; } = null!;

    public int RoomId { get; set; }

    public DateTime CheckInDate { get; set; }

    public DateTime? CheckoutDate { get; set; }

    public virtual Room Room { get; set; } = null!;
}
