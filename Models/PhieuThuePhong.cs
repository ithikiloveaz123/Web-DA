using System;
using System.Collections.Generic;

namespace Web_DA.Models;

public partial class PhieuThuePhong
{
    public string MaPtp { get; set; } = null!;

    public string MaPdp { get; set; } = null!;

    public string MaKh { get; set; } = null!;

    public string MaNv { get; set; } = null!;

    public DateOnly NgayThue { get; set; }

    public DateOnly NgayTra { get; set; }

    public virtual ICollection<CtphieuThuePhong> CtphieuThuePhongs { get; set; } = new List<CtphieuThuePhong>();

    public virtual HoaDon? HoaDon { get; set; }

    public virtual KhachHang MaKhNavigation { get; set; } = null!;

    public virtual NhanVien MaNvNavigation { get; set; } = null!;

    public virtual PhieuDatPhong MaPdpNavigation { get; set; } = null!;
}
