using System;
using System.Collections.Generic;

namespace Web_DA.Models;

public partial class QuanTri
{
    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool TinhTrang { get; set; }

    public string MaNv { get; set; } = null!;

    public string Idnhom { get; set; } = null!;

    public virtual NhomNhanVien IdnhomNavigation { get; set; } = null!;

    public virtual NhanVien MaNvNavigation { get; set; } = null!;
}
