using System;
using System.Collections.Generic;

namespace Web_DA.Models;

public partial class LoaiPhong
{
    public string MaLp { get; set; } = null!;

    public string TenLp { get; set; } = null!;

    public string HinhAnh { get; set; } = null!;

    public int SucChua { get; set; }

    public decimal DonGia { get; set; }

    public string? MoTa { get; set; }

    public virtual ICollection<Phong> Phongs { get; set; } = new List<Phong>();
}
