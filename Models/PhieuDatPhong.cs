using System;
using System.Collections.Generic;

namespace Web_DA.Models;

public partial class PhieuDatPhong
{
    public string MaPdp { get; set; } = null!;

    public string MaKh { get; set; } = null!;

    public DateOnly NgayDen { get; set; }

    public DateOnly NgayDi { get; set; }

    public decimal TongTienCoc { get; set; }

    public int SoNguoi { get; set; }

    public bool TinhTrang { get; set; }

    public string MaNv { get; set; } = null!;

    public virtual ICollection<CtphieuDatPhong> CtphieuDatPhongs { get; set; } = new List<CtphieuDatPhong>();

    public virtual KhachHang MaKhNavigation { get; set; } = null!;

    public virtual NhanVien MaNvNavigation { get; set; } = null!;

    public virtual ICollection<PhieuThuePhong> PhieuThuePhongs { get; set; } = new List<PhieuThuePhong>();
}
