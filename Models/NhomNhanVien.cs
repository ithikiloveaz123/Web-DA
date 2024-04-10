using System;
using System.Collections.Generic;

namespace Web_DA.Models;

public partial class NhomNhanVien
{
    public string Idnhom { get; set; } = null!;

    public string TenNhom { get; set; } = null!;

    public virtual ICollection<DanhSachQuyen> DanhSachQuyens { get; set; } = new List<DanhSachQuyen>();

    public virtual ICollection<QuanTri> QuanTris { get; set; } = new List<QuanTri>();
}
