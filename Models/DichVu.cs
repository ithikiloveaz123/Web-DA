using System;
using System.Collections.Generic;

namespace Web_DA.Models;

public partial class DichVu
{
    public string MaDv { get; set; } = null!;

    public string TenDv { get; set; } = null!;

    public decimal Gia { get; set; }

    public virtual ICollection<CtphieuThuePhong> CtphieuThuePhongs { get; set; } = new List<CtphieuThuePhong>();
}
