using System;
using System.Collections.Generic;

namespace HostelManagementApp.Models;

public partial class Bill
{
    public int BillId { get; set; }

    public int RoomId { get; set; }

    public DateTime CreatedBillDate { get; set; }

    public DateTime DateOfPayment { get; set; }

    public bool BillStatus { get; set; }

    public int? WaterM3 { get; set; }

    public int? Internet { get; set; }

    public int? ElectricityKwh { get; set; }

    public int? GarbageCollection { get; set; }

    public virtual Room Room { get; set; } = null!;
}
