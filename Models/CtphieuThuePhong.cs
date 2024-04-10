using System;
using System.Collections.Generic;

namespace Web_DA.Models;

public partial class CtphieuThuePhong
{
    public string MaPtp { get; set; } = null!;

    public string MaP { get; set; } = null!;

    public DateTime NgaySd { get; set; }

    public string MaDv { get; set; } = null!;

    public int SoLuong { get; set; }

    public virtual DichVu MaDvNavigation { get; set; } = null!;

    public virtual Phong MaPNavigation { get; set; } = null!;

    public virtual PhieuThuePhong MaPtpNavigation { get; set; } = null!;
}
