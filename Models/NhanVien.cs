using System;
using System.Collections.Generic;

namespace Web_DA.Models;

public partial class NhanVien
{
    public string MaNv { get; set; } = null!;

    public string TenNv { get; set; } = null!;

    public bool GioiTinh { get; set; }

    public DateOnly NgaySinh { get; set; }

    public string DiaChi { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Sdt { get; set; } = null!;

    public string HinhAnh { get; set; } = null!;

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    public virtual ICollection<PhieuDatPhong> PhieuDatPhongs { get; set; } = new List<PhieuDatPhong>();

    public virtual ICollection<PhieuThuePhong> PhieuThuePhongs { get; set; } = new List<PhieuThuePhong>();

    public virtual ICollection<QuanTri> QuanTris { get; set; } = new List<QuanTri>();
}
