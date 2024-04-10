using System;
using System.Collections.Generic;

namespace Web_DA.Models;

public partial class KhachHang
{
    public string MaKh { get; set; } = null!;

    public string TenKh { get; set; } = null!;

    public bool GioiTinh { get; set; }

    public string CmndPassport { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public string QuocTich { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Sdt { get; set; } = null!;

    public virtual ICollection<PhieuDatPhong> PhieuDatPhongs { get; set; } = new List<PhieuDatPhong>();

    public virtual ICollection<PhieuThuePhong> PhieuThuePhongs { get; set; } = new List<PhieuThuePhong>();
}
