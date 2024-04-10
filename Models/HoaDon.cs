using System;
using System.Collections.Generic;

namespace Web_DA.Models;

public partial class HoaDon
{
    public string MaHd { get; set; } = null!;

    public DateTime NgayTt { get; set; }

    public string MaPtp { get; set; } = null!;

    public string MaNv { get; set; } = null!;

    public decimal TongTien { get; set; }

    public virtual NhanVien MaNvNavigation { get; set; } = null!;

    public virtual PhieuThuePhong MaPtpNavigation { get; set; } = null!;
}
