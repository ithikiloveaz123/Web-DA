using System;
using System.Collections.Generic;

namespace Web_DA.Models;

public partial class DanhSachQuyen
{
    public string Idnhom { get; set; } = null!;

    public string Idquyen { get; set; } = null!;

    public string? GhiChu { get; set; }

    public virtual NhomNhanVien IdnhomNavigation { get; set; } = null!;

    public virtual Quyen IdquyenNavigation { get; set; } = null!;
}
